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
using PeP_UI.Util;
using PeP_API.Models;
using System.Net.Mail;

namespace PeP_UI.Users
{
    public partial class frm_Korisnici : Form
    {
        WebApiHelper korisniciService = new WebApiHelper("http://localhost:30455/", "api/Korisnici");
        WebApiHelper ulogeService = new WebApiHelper("http://localhost:30455/", "api/Uloge");
        public frm_Korisnici()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            dgKorisnici.AutoGenerateColumns = false;

        }

        private void KorisniciForm_Load(object sender, EventArgs e)
        {
            BindForm();
            BindGrid();

        }

        private void BindForm()
        {

           
            HttpResponseMessage ulogeResponse = ulogeService.GetResponse();


            



            if (ulogeResponse.IsSuccessStatusCode)
            {
                ((ListBox)ulogeList).DataSource = ulogeResponse.Content.ReadAsAsync<List<Uloge>>().Result;
                ((ListBox)ulogeList).DisplayMember = "Naziv";
                ((ListBox)ulogeList).ValueMember = "UlogaID";
                ulogeList.ClearSelected();
                for (int i = 0; i < ulogeList.Items.Count; i++)
                {
                    ulogeList.SetItemChecked(i, false);
                }
                


            }

            else
            {

                MessageBox.Show("Error Code:" + ulogeResponse.StatusCode + "Message: " + ulogeResponse.ReasonPhrase);
            }






        }
        private void BindGrid()
        {
            HttpResponseMessage korisniciResponse = korisniciService.GetActionResponse("SearchKorisnici", txtImePrezimePretraga.Text.Trim());
            if (korisniciResponse.IsSuccessStatusCode)
            {
                List<Korisnici> korisnici = korisniciResponse.Content.ReadAsAsync<List<Korisnici>>().Result;
                dgKorisnici.DataSource = korisnici;



            }

            else
            {

                MessageBox.Show("Error Code:" + korisniciResponse.StatusCode + "Message: " + korisniciResponse.ReasonPhrase);
            }
        }

        private void ClearInput()
        {

            txtIme.Text = txtPrezime.Text = txtTelefon.Text = txtEmail.Text = txtKorisnickoIme.Text = txtLozinka.Text = "";
            ulogeList.ClearSelected();
          for (int i = 0; i <ulogeList.Items.Count; i++)
			{
			 ulogeList.GetItemChecked(i).Equals(false);
			}

            
	
		 
	}

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("SearchKorisniciById", Convert.ToInt32(dgKorisnici.SelectedRows[0].Cells[0].Value));

          
            Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;
            frm_KorisniciUredi frm = new frm_KorisniciUredi(k);
         
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                txtImePrezimePretraga.Text = "";
                BindGrid();
            }
         
        }

        private void btnSacuvaj_Click_1(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                ulogeList.Refresh();
                Korisnici k = new Korisnici();
                k.Ime = txtIme.Text;
                k.Prezime = txtPrezime.Text;
                k.Email = txtEmail.Text;
                k.Telefon = txtTelefon.Text;
                k.KorisnickoIme = txtKorisnickoIme.Text;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(txtLozinka.Text, k.LozinkaSalt);
                k.Uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();



                HttpResponseMessage response = korisniciService.PostResponse(k);

                if (response.IsSuccessStatusCode)
                {


                    MessageBox.Show("Korisnik "+k.Ime+" "+k.Prezime+" uspjesno dodat!");
                    BindGrid();
                    ClearInput();




                }
                else
                {


                    MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                }



            }

        }


        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            int korisnikID = Convert.ToInt32(dgKorisnici.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = korisniciService.GetActionResponse("SearchKorisniciById", korisnikID);
            if (response.IsSuccessStatusCode)
            {
                Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;

                if (k.Status)
                    k.Status = false;
                else
                    k.Status = true;

                response = korisniciService.PutActionResponse(k.KorisnikID, k);
                BindGrid();
            }

            else
            {


                MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
            }

        }

       

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, Global.GetMessage("fname_req"));
            }

            else
            {
                errorProvider.SetError(txtIme, Global.GetMessage(""));
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {

                e.Cancel = true;
                errorProvider.SetError(txtEmail, Global.GetMessage("email_req"));

            }


            else
            {
                try
                {
                    MailAddress mail = new MailAddress(txtEmail.Text);
             
                errorProvider.SetError(txtEmail, Global.GetMessage(""));
            
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtEmail, Global.GetMessage("email_error"));

                }
            }

        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, Global.GetMessage("prezime_req"));
            }
            else
            {

                errorProvider.SetError(txtPrezime, "");
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtKorisnickoIme.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, Global.GetMessage("field_req"));

            }
            if (txtKorisnickoIme.TextLength < 4)
            {

                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, Global.GetMessage("username_short"));
            }

            else
            {

                errorProvider.SetError(txtKorisnickoIme, "");
            }

        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtLozinka.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Global.GetMessage("pass_req"));

            }

            if (txtLozinka.TextLength < 5)
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Global.GetMessage("pass_err"));
            }
            else
            {
                errorProvider.SetError(txtLozinka, "");
            }
        }

        private void ulogeList_Validating(object sender, CancelEventArgs e)
        {
            if (ulogeList.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(ulogeList, Global.GetMessage("roles_req"));

            }
            else
            {
                errorProvider.SetError(ulogeList, "");
            }
        }

        private void btnOdustani_Click_1(object sender, EventArgs e)
        {
            ClearInput();
        }
    }
}

