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

namespace PeP_UI.Orders
{
    public partial class frm_Narudzbe : Form
    {

        WebApiHelper narudzbeService = new WebApiHelper("http://localhost:30455", "api/Narudzbe");
        WebApiHelper skladistaService = new WebApiHelper("http://localhost:30455", "api/Skladista");
        WebApiHelper izlaziService = new WebApiHelper("http://localhost:30455", "api/Izlazi");
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:30455", "api/Proizvodi");

        Narudzbe_Result odabranaNarudzba = new Narudzbe_Result();
        List<NarudzbeStavke_Result> stavkeNarudzbe;
        public frm_Narudzbe()
        {
            InitializeComponent();
        }

        private void frm_Narudzbe_Load(object sender, EventArgs e)
        {
                        
            BindGridNarudzbeAll();

            BindForm();


        }

        private void BindForm()
        {
            HttpResponseMessage responseSkladista = skladistaService.GetResponse();
            if (responseSkladista.IsSuccessStatusCode)
            {

                List<Skladista> skladista = responseSkladista.Content.ReadAsAsync<List<Skladista>>().Result;
                skladista.Insert(0, new Skladista());
                listSkladista.DataSource = skladista;
                listSkladista.ValueMember = "SkladisteID";
                listSkladista.DisplayMember = "Naziv";

            }

            else {

                MessageBox.Show("Error: " + responseSkladista.StatusCode + Environment.NewLine + "Message: " + responseSkladista.ReasonPhrase);

            }







        }

        private void BindGridNarudzbe()
        {
            string date = txtDatum.Value.Year.ToString() + "-" + txtDatum.Value.Month.ToString() + "-" + txtDatum.Value.Day.ToString();
            HttpResponseMessage responseNarudzbe = narudzbeService.GetActionResponse("SelectAktivne",date);


            if (responseNarudzbe.IsSuccessStatusCode)
            {

                 dgNarudzbe.AutoGenerateColumns = false;
                dgNarudzbe.DataSource = responseNarudzbe.Content.ReadAsAsync<List<Narudzbe_Result>>().Result;
           

            }

            else {


                MessageBox.Show("Error: " + responseNarudzbe.StatusCode + Environment.NewLine + "Message: " + responseNarudzbe.ReasonPhrase);



            }
        }

        private void BindGridNarudzbeAll()
        {
            HttpResponseMessage responseNarudzbe = narudzbeService.GetActionResponse("SelectAktivne", "");


            if (responseNarudzbe.IsSuccessStatusCode)
            {

                dgNarudzbe.AutoGenerateColumns = false;

                dgNarudzbe.DataSource = responseNarudzbe.Content.ReadAsAsync<List<Narudzbe_Result>>().Result;
              if(dgNarudzbe.ColumnCount!=0)
                    dgNarudzbe_CellContentClick(null, null);

            }

            else
            {


                MessageBox.Show("Error: " + responseNarudzbe.StatusCode + Environment.NewLine + "Message: " + responseNarudzbe.ReasonPhrase);



            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGridNarudzbe();
        }

        private void btnProcesiraj_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                bool imaNaSkladistu = true;

                
           
               Izlazi izlaz = new Izlazi();
                izlaz.KorisnikID = Global.prijavljeniKorisnici.KorisnikID;
                izlaz.NarudzbaID = odabranaNarudzba.NarudzbaID;
                izlaz.IznosSaPDV = (decimal)odabranaNarudzba.Iznos;
                izlaz.IznosBezPDV = (decimal)odabranaNarudzba.Iznos / (decimal)1.17;
                izlaz.SkladisteID = Convert.ToInt32(listSkladista.SelectedValue);
                string message = "";
            
                for (int i = 0; i < stavkeNarudzbe.Count; i++) {


                    HttpResponseMessage responseProizvodi = proizvodiService.GetActionResponse("StanjeNaSkladistu", stavkeNarudzbe[i].ProizvodID, izlaz.SkladisteID);
                    if (responseProizvodi.IsSuccessStatusCode)
                    {
                        int stanjeNaSkladistu = responseProizvodi.Content.ReadAsAsync<int>().Result;
                        if (stanjeNaSkladistu < stavkeNarudzbe[i].Kolicina)
                        {
                          
                            imaNaSkladistu = false;
                            message += "Proizvoda " + stavkeNarudzbe[i].Naziv + " nema dovoljno na odabranom skladištu!" + Environment.NewLine;
                        }
                    }
                    else {

                        MessageBox.Show("Error: " + responseProizvodi.StatusCode + Environment.NewLine + "Message: " + responseProizvodi.ReasonPhrase);

                    }

                }


                if (imaNaSkladistu)
                {


                    HttpResponseMessage responseIzlazi = izlaziService.PostResponse(izlaz);
                    if (responseIzlazi.IsSuccessStatusCode)
                    {

                        
                        MessageBox.Show("Narudža " +odabranaNarudzba.BrojNarudzbe +" uspješno procesirana!");

                        HttpResponseMessage responseNarudzbe = narudzbeService.GetActionResponse("SelectAktivne", txtDatum.Text.Trim());
                        dgNarudzbe.Refresh();
                        BindGridNarudzbe();


                    }
                    else {
                        MessageBox.Show("Error: " + responseIzlazi.StatusCode + Environment.NewLine + "Message: " + responseIzlazi.ReasonPhrase);


                    }


                }



                else {

                    MessageBox.Show(message);


                }
            }





        }

        private void dgNarudzbe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgNarudzbe.ColumnCount!=0)
            {
                HttpResponseMessage responseNarudzba = narudzbeService.GetResponse(Convert.ToInt32(dgNarudzbe.SelectedRows[0].Cells[0].Value));
                if (responseNarudzba.IsSuccessStatusCode)
                {
                    odabranaNarudzba = responseNarudzba.Content.ReadAsAsync<Narudzbe_Result>().Result;
                }
                else
                {


                    MessageBox.Show("Error: " + responseNarudzba.StatusCode + Environment.NewLine + "Message: " + responseNarudzba.ReasonPhrase);


                }
                HttpResponseMessage responseStavkeNarudzbe = narudzbeService.GetActionResponse("SelectStavke", Convert.ToInt32(dgNarudzbe.SelectedRows[0].Cells[0].Value));
                if (responseStavkeNarudzbe.IsSuccessStatusCode)
                {
                    stavkeNarudzbe = responseStavkeNarudzbe.Content.ReadAsAsync<List<NarudzbeStavke_Result>>().Result;
                    dgStavkeNarudzbe.AutoGenerateColumns = false;

                    dgStavkeNarudzbe.DataSource = stavkeNarudzbe;
                    lblKupac.Text = Convert.ToString(dgNarudzbe.SelectedRows[0].Cells[3].Value);
                    lblDatum.Text = Convert.ToString(dgNarudzbe.SelectedRows[0].Cells[2].Value);
                    lblIznos.Text = Convert.ToString(dgNarudzbe.SelectedRows[0].Cells[4].Value);
                    lblBrojNaruzbe.Text = Convert.ToString(dgNarudzbe.SelectedRows[0].Cells[1].Value);
                }

                else
                {

                    MessageBox.Show("Error: " + responseStavkeNarudzbe.StatusCode + Environment.NewLine + "Message: " + responseStavkeNarudzbe.ReasonPhrase);

                }
            }




        }

      

        private void listSkladista_Validating(object sender, CancelEventArgs e)
        {
            if (listSkladista.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(listSkladista, Global.GetMessage("field_req"));
            }
            else
            {
                errorProvider.SetError(listSkladista, "");
            }
        }
    }
}
