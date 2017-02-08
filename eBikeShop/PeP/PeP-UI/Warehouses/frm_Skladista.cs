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

namespace PeP_UI.Warehouses
{
    public partial class frm_Skladista : Form
    {
        WebApiHelper skladistaService = new WebApiHelper("http://localhost:30455/", "api/Skladista");
        Skladista skladiste = new Skladista();

        public frm_Skladista()
        {
            InitializeComponent();
        }

        private void frm_Skladista_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = skladistaService.GetActionResponse("SearchByNameOrAddress", txtNazivAdresaPretraga.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                dgSkladista.AutoGenerateColumns = false;
                dgSkladista.DataSource = response.Content.ReadAsAsync<List<Skladista>>().Result;

            }

        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = skladistaService.GetResponse(Convert.ToInt32(dgSkladista.SelectedRows[0].Cells[0].Value));
            if (response.IsSuccessStatusCode)
            {
                skladiste = response.Content.ReadAsAsync<Skladista>().Result;

                frm_SkladistaUredi frm = new frm_SkladistaUredi(skladiste);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK) {
                    txtNazivAdresaPretraga.Text = "";
                    BindGrid();

                }

            }


            else
            {

                MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);

            }


        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                skladiste.Naziv = txtNaziv.Text;
                skladiste.Adresa = txtAdresa.Text;
                skladiste.Opis = txtOpis.Text;

                HttpResponseMessage response = skladistaService.PostResponse(skladiste);
                if (response.IsSuccessStatusCode)
                {


                    MessageBox.Show("Skladište " + skladiste.Naziv + " uspješno dodano!");
                    BindGrid();
                    ClearInput();




                }
                else
                {


                    MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                }
            }
        }

        private void ClearInput()
        {
            txtAdresa.Text = txtNaziv.Text = txtOpis.Text = "";
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            ClearInput();
        }



        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtAdresa.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtAdresa, Global.GetMessage("field_req"));
            }
            else
            {

                errorProvider.SetError(txtAdresa, "");
            }
        }

        private void txtNazivSkladista_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNaziv.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Global.GetMessage("field_req"));
            }
            else
            {
                errorProvider.SetError(txtNaziv, "");
            }
        }
    }
}
