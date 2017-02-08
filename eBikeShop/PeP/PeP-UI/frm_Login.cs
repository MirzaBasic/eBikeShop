using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeP_UI.Util;
using System.Net.Http;
using PeP_API.Models;

namespace PeP_UI
{


    public partial class frm_Login : Form
    {
        private WebApiHelper korisniciService = new WebApiHelper("http://localhost:30455/", "api/Korisnici");
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();





        }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = korisniciService.GetResponse(txtKorisnickoIme.Text);
            if(response.IsSuccessStatusCode)
            {
                if (txtLozinka.Text != "")
                {


                    Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;
                    if (UIHelper.GenerateHash(txtLozinka.Text, k.LozinkaSalt) == k.LozinkaHash)
                    {
                        Global.prijavljeniKorisnici = k;
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    else
                    {


                        MessageBox.Show(Global.GetMessage("login_pass_error"), Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Error Code:" + response.StatusCode + "Message: " + response.ReasonPhrase);
                }

            }
        }

        private void txtLozinka_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                btnPrijavi_Click(null, null);
            }
        }

        private void txtKorisnickoIme_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                btnPrijavi_Click(null, null);
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

      

        
    }
}
