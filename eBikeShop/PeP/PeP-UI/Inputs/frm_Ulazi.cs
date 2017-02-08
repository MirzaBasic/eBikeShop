using PeP_API.Models;
using PeP_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeP_UI.Inputs
{
    public partial class frm_Ulazi : Form
    {
        WebApiHelper dobavljaciService = new WebApiHelper("http://localhost:30455", "api/Dobavljaci");
        WebApiHelper ulaziService = new WebApiHelper("http://localhost:30455", "api/Ulazi");
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:30455", "api/Proizvodi");
        WebApiHelper skladistaService = new WebApiHelper("http://localhost:30455", "api/Skladista");
        WebApiHelper ulaziStavkeService = new WebApiHelper("http://localhost:30455", "api/UlazStavke");

        Ulazi ulaz = new Ulazi();
        List<UlazStavke> ulaziStavke = new List<UlazStavke>();
        Proizvodi p = new Proizvodi();

        decimal cijena = 0;
        decimal PDV = 0;
        public frm_Ulazi()
        {
            InitializeComponent();
        }

        private void btnDodajDobavljaca_Click(object sender, EventArgs e)
        {
            Suppliers.frm_Dobavljaci form = new Suppliers.frm_Dobavljaci();

            form.Show();


        }

        private void frm_Ulazi_Load(object sender, EventArgs e)
        {

            BindForm();
        }

        private void BindForm()
        {

            HttpResponseMessage responseDobavljaci = dobavljaciService.GetResponse();
            if (responseDobavljaci.IsSuccessStatusCode)
            {
                List<Dobavljaci> dobavljaci = responseDobavljaci.Content.ReadAsAsync<List<Dobavljaci>>().Result;
                dobavljaci.Insert(0, new Dobavljaci());
                listDobavljac.DataSource = dobavljaci;
                listDobavljac.ValueMember = "DobavljacID";
                listDobavljac.DisplayMember = "Naziv";
            }

            else
            {
                MessageBox.Show("Error: " + responseDobavljaci.StatusCode + Environment.NewLine + "Message: " + responseDobavljaci.ReasonPhrase);


            }



            HttpResponseMessage responseSkladista = skladistaService.GetResponse();

            if (responseDobavljaci.IsSuccessStatusCode)
            {
                List<Skladista> skladista = responseSkladista.Content.ReadAsAsync<List<Skladista>>().Result;
                skladista.Insert(0, new Skladista());
                listSkladiste.DataSource = skladista;
                listSkladiste.ValueMember = "SkladisteID";
                listSkladiste.DisplayMember = "Naziv";
            }

            else
            {

                MessageBox.Show("Error: " + responseSkladista.StatusCode + Environment.NewLine + "Message: " + responseSkladista.ReasonPhrase);


            }


        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {

            HttpResponseMessage responseProizvod = proizvodiService.GetActionResponse("SearchBySifra", txtSifra.Text);


            if (responseProizvod.IsSuccessStatusCode)
            {


                p = responseProizvod.Content.ReadAsAsync<Proizvodi>().Result;
                if (p != null)
                {


                    txtCijena.Text = p.Cijena.ToString();
                    txtNaziv.Text = p.Naziv;
                }
                else
                {

                    MessageBox.Show("Proizvod nije pronadjen!");


                }



            }
            else
            {

                MessageBox.Show("Error: " + responseProizvod.StatusCode + Environment.NewLine + "Message: " + responseProizvod.ReasonPhrase);


            }


        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {

            if (txtKolicina.Text != "")
            {
                UlazStavke uls = new UlazStavke();
                uls.Cijena = p.Cijena * Convert.ToInt32(txtKolicina.Text);
                uls.ProizvodID = p.ProizvodID;
                uls.NazivProizvoda = p.Naziv;
                uls.SifraProizvoda = p.Sifra;

                uls.Kolicina = Convert.ToInt32(txtKolicina.Text);

                ulaziStavke.Add(uls);

                dgProizvodi.AutoGenerateColumns = false;
                dgProizvodi.DataSource = ulaziStavke.ToList();


                cijena += p.Cijena * Convert.ToInt32(txtKolicina.Text);
                PDV += p.Cijena * (decimal)0.17;
                txtIznosRacuna.Text = cijena.ToString();
                txtPDV.Text = PDV.ToString();








            }

            else
            {

                MessageBox.Show("Molimo unesite kolicinu!");
            }


        }

        private void btnDodajSkladiste_Click(object sender, EventArgs e)
        {
            Warehouses.frm_Skladista form = new Warehouses.frm_Skladista();
            form.Show();
        }



        private void btnPonisti_Click(object sender, EventArgs e)
        {







        }

        private void btnProcesiraj_Click(object sender, EventArgs e)
        {


            if (this.ValidateChildren())
            {
                Ulazi ulaz = new Ulazi();
                ulaz.DobavljacID = Convert.ToInt32(listDobavljac.SelectedValue);
                ulaz.BrojFakture = txtFaktura.Text;
                ulaz.IznosRacuna = cijena;
                ulaz.KorisnikID = Global.prijavljeniKorisnici.KorisnikID;
                ulaz.Napomena = txtNapomena.Text;
                ulaz.SkladisteID = Convert.ToInt32(listSkladiste.SelectedValue);
                ulaz.PDV = PDV;
                ulaz.Datum = DateTime.Now;
                HttpResponseMessage responseUlazi = ulaziService.PostResponse(ulaz);
                bool addSuccess = true;

                if (responseUlazi.IsSuccessStatusCode)
                {
                    int ulazID = responseUlazi.Content.ReadAsAsync<int>().Result;
                    for (int i = 0; i < ulaziStavke.Count; i++)
                    {
                        ulaziStavke[i].UlazID = ulazID;
                        HttpResponseMessage responseUlaziStavke = ulaziStavkeService.PostResponse(ulaziStavke[i]);

                        if (!responseUlaziStavke.IsSuccessStatusCode)
                        {

                            addSuccess = false;
                            MessageBox.Show("Error: " + responseUlaziStavke.StatusCode + Environment.NewLine + "Message: " + responseUlaziStavke.ReasonPhrase);



                        }
                    }

                    if (addSuccess)
                    {
                        MessageBox.Show("Ulazna faktura uspješno procesirana!");
                    }

                    else
                    {


                        MessageBox.Show("Error: " + responseUlazi.StatusCode + Environment.NewLine + "Message: " + responseUlazi.ReasonPhrase);




                    }

                }
            }
        }


        private void listSkladiste_Validating(object sender, CancelEventArgs e)
        {
            if (listSkladiste.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(listSkladiste, Global.GetMessage("field_req"));
            }
            else
            {
                errorProvider.SetError(listSkladiste, "");
            }
        }

        private void listDobavljac_Validating(object sender, CancelEventArgs e)
        {
            if (listDobavljac.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(listDobavljac, Global.GetMessage("field_req"));
            }
            else
            {
                errorProvider.SetError(listDobavljac, "");
            }
        }

        private void txtFaktura_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtFaktura.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtFaktura, Global.GetMessage("field_req"));
            }
            else
            {

                errorProvider.SetError(txtFaktura, "");
            }

        }

        private void txtIznosRacuna_Validating(object sender, CancelEventArgs e)
        {

        }



        private void txtSifra_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSifra.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSifra, Global.GetMessage("field_req"));
            }
            else
            {

                errorProvider.SetError(txtSifra, "");
            }

        }



        private void txtKolicina_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtKolicina.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKolicina, Global.GetMessage("field_req"));
            }

            else
            {

                errorProvider.SetError(txtKolicina, "");
            }

        }

        private void txtKolicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }



        }


    }
}
