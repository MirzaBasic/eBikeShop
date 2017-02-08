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

namespace PeP_UI.Suppliers
{
    public partial class frm_Dobavljaci : Form
    {
        WebApiHelper dobavljaciService = new WebApiHelper("http://localhost:30455/", "api/Dobavljaci");
        Dobavljaci dobavljac = new Dobavljaci();

        public frm_Dobavljaci()
        {
            InitializeComponent();
            cbxStatus.Checked = true;
        }
        private void frm_Dobavljaci_Load(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void BindGrid()
        {
            HttpResponseMessage responseDobavljaci = dobavljaciService.GetActionResponse("Search", txtNazivPretraga.Text.Trim());

            if (responseDobavljaci.IsSuccessStatusCode) {
                dgDobavljaci.AutoGenerateColumns = false;
                dgDobavljaci.DataSource = responseDobavljaci.Content.ReadAsAsync<List<Dobavljaci>>().Result;

            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {

          
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {


            HttpResponseMessage response = dobavljaciService.GetResponse(Convert.ToInt32(dgDobavljaci.SelectedRows[0].Cells[0].Value));
            if (response.IsSuccessStatusCode)
            {
                Dobavljaci d = response.Content.ReadAsAsync<Dobavljaci>().Result;
                frm_DobavljaciUredi frm = new frm_DobavljaciUredi(d);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    txtNazivPretraga.Text = "";
                    BindGrid();
                }

            }

            else
            {

                MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);

            }





        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {


            if (this.ValidateChildren())
            {
                dobavljac.Naziv = txtNaziv.Text;
                dobavljac.KontaktOsoba = txtKontakt.Text;
                dobavljac.Telefon = txtTelefon.Text;
                dobavljac.Email = txtEmail.Text;
                dobavljac.Fax = txtFax.Text;
                dobavljac.ZiroRacuni = txtBrojRacuna.Text;
                dobavljac.Napomena = txtNapomena.Text;
                dobavljac.Status = cbxStatus.Checked;
                dobavljac.Web = txtWeb.Text;
                dobavljac.Adresa = txtAdresa.Text;

                HttpResponseMessage response = dobavljaciService.PostResponse(dobavljac);
                if (response.IsSuccessStatusCode)
                {

                    MessageBox.Show("Dobavljač " + dobavljac.Naziv + " uspješno dodan!");
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



            txtNaziv.Text =
            txtKontakt.Text =
             txtTelefon.Text =
            txtEmail.Text =
            txtFax.Text =
             txtBrojRacuna.Text =
            txtNapomena.Text =
               txtWeb.Text =
          txtAdresa.Text = "";
            cbxStatus.Checked = false;
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNaziv.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Global.GetMessage("field_req"));
            }
            else
            { errorProvider.SetError(txtNaziv, ""); }
        }

        private void txtKontaktOsoba_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtKontakt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKontakt, Global.GetMessage("field_req"));
            }
            else
            { errorProvider.SetError(txtKontakt, ""); }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtAdresa.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtAdresa, Global.GetMessage("field_req"));
            }
            else
            { errorProvider.SetError(txtAdresa, ""); }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefon.MaskCompleted)
            {
                errorProvider.SetError(txtTelefon, "");

            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, Global.GetMessage("field_req"));
            }
        }

        private void txtWeb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtWeb.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtWeb, Global.GetMessage("field_req"));
            }
            else
            { errorProvider.SetError(txtWeb, ""); }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Global.GetMessage("field_req"));
            }
            else
            {

                try
                {
                    System.Net.Mail.MailAddress mail = new System.Net.Mail.MailAddress(txtEmail.Text);
                    errorProvider.SetError(txtEmail, "");
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtEmail, Global.GetMessage("email_err"));
                }
            }
        }

        private void txtZR_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtBrojRacuna.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrojRacuna, Global.GetMessage("field_req"));

            }
            else
            {
                errorProvider.SetError(txtBrojRacuna, "");
            }

        }

        private void txtZR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
