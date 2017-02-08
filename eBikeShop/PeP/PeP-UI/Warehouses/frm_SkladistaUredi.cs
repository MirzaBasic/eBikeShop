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
    public partial class frm_SkladistaUredi : Form
    {
        Skladista skladiste = new Skladista();
        WebApiHelper skladistaServise = new WebApiHelper("http://localhost:30455/", "api/Skladista");


        public frm_SkladistaUredi(Skladista s)
        {
            skladiste = s;
            InitializeComponent();
        }

        private void frm_SkladistaUredi_Load(object sender, EventArgs e)
        {
            BindForm();
        }

        private void BindForm()
        {
            txtAdresa.Text = skladiste.Adresa;
            txtNaziv.Text = skladiste.Naziv;
            txtOpis.Text = skladiste.Opis;
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                skladiste.Adresa = txtAdresa.Text;
                skladiste.Naziv = txtNaziv.Text;
                skladiste.Opis = txtOpis.Text;


                HttpResponseMessage response = skladistaServise.PutActionResponse(skladiste.SkladisteID, skladiste);
                if (response.IsSuccessStatusCode)
                {


                    MessageBox.Show("Skladište " + skladiste.Naziv + " uspješno izmijenjen!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {


                    MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                }
            }

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
