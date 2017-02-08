using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeP_API.Models;
using PeP_UI.Util;
using System.Net.Http;
using System.Net.Mail;

namespace PeP_UI.Users
{
    public partial class frm_KorisniciUredi : Form
    {
        Korisnici k = new Korisnici();
        WebApiHelper korisniciService = new WebApiHelper("http://localhost:30455/", "api/Korisnici");
        WebApiHelper ulogeService = new WebApiHelper("http://localhost:30455/", "api/Uloge");
      
     
        public frm_KorisniciUredi(Korisnici k)
        {
            
            this.k = k;
            
            HttpResponseMessage ulogeResponse = ulogeService.GetResponse();
            InitializeComponent();
            
            txtIme.Text = k.Ime;
            txtPrezime.Text = k.Prezime;
            txtEmail.Text = k.Email;
            txtTelefon.Text = k.Telefon;
            txtKorisnickoIme.Text = k.KorisnickoIme;
            ((ListBox)ulogeList).DataSource = ulogeResponse.Content.ReadAsAsync<List<Uloge>>().Result;
            ((ListBox)ulogeList).DisplayMember = "Naziv";
             ((ListBox)ulogeList).ValueMember = "UlogaID";

             ulogeResponse = korisniciService.GetActionResponse(k.KorisnikID, "Uloge");
              List< Uloge> ulogeKorisnika=ulogeResponse.Content.ReadAsAsync<List<Uloge>>().Result;

              k.Uloge=ulogeKorisnika;
           
                for (int i = 0; i < ulogeKorisnika.Count; i++)
                {
                
                        ulogeList.SetItemChecked(ulogeKorisnika[i].UlogaID, true);
                    
                }
               
            
           



           
           

        }

       

        private void frm_KorisniciUredi_Load(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                k.Ime = txtIme.Text;
                k.Prezime = txtPrezime.Text;
                k.Telefon = txtTelefon.Text;
                k.Email = txtEmail.Text;
                k.KorisnickoIme = txtKorisnickoIme.Text;
                if (txtLozinka.Text != "")
                {
                    k.LozinkaSalt = UIHelper.GenerateSalt();
                    k.LozinkaHash = UIHelper.GenerateHash(txtLozinka.Text,k.LozinkaSalt);
                }

              

                k.Uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();





                HttpResponseMessage responseKorisnici = korisniciService.PutActionResponse(k.KorisnikID, k);
                if (responseKorisnici.IsSuccessStatusCode)
                {

                    MessageBox.Show("Korisnik uspjesno izmijenjen!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();


                }
                else
                {

                    MessageBox.Show("Error Code:" + responseKorisnici.StatusCode + "Message: " + responseKorisnici.ReasonPhrase);

                }
            }
        }

        private void btnDodajUlogu_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response;
            response = ulogeService.PostActionResponse("AddUloge", k.KorisnikID, ulogeList.CheckedItems.Cast<Uloge>().ToList());

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

       

      
    }
}
