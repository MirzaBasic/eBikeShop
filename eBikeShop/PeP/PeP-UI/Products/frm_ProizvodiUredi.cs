using PeP_API.Models;
using PeP_API.Util;
using PeP_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeP_UI.Products
{
    public partial class frm_ProizvodiUredi : Form
    {
        WebApiHelper vrsteService = new WebApiHelper("http://localhost:30455/", "api/VrsteProizvoda");
        WebApiHelper jediniceMjereService = new WebApiHelper("http://localhost:30455/", "api/JediniceMjere");
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:30455/", "api/Proizvodi");
        Proizvodi proizvod = new Proizvodi();
        public frm_ProizvodiUredi(Proizvodi p)
        {
            InitializeComponent();

            proizvod = p;
           



          
        
           

        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {

            openFileDialog.ShowDialog();
            txtSlika.Text = openFileDialog.FileName;
            Image image = Image.FromFile(txtSlika.Text);


            MemoryStream ms = new MemoryStream();

            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            proizvod.Slika = ms.ToArray();

            int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
            int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
            int croppedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
            int croppedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);

            if (image.Width > resizedImgWidth)
            {


                Image resizedImage = UIHelper.ResizeImage(image, new Size(resizedImgWidth, resizedImgHeight));



                Image croppedImage = resizedImage;
                int croppedXPosition = (resizedImage.Width - croppedImgWidth) / 2;
                int croppedYPosition = (resizedImage.Height - croppedImgHeight) / 2;

                if (resizedImage.Width >= croppedImgWidth && resizedImage.Height >= croppedImgHeight)
                {

                    croppedImage = UIHelper.CropImage(resizedImage, new Rectangle(croppedXPosition, croppedYPosition, croppedImgWidth, croppedImgHeight));
                    croppedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    proizvod.SlikaThumb = ms.ToArray();
                    slikaBox.Image = resizedImage;

                }
            }

        }

        private void frm_ProizvodiUredi_Load(object sender, EventArgs e)
        {

            txtNaziv.Text = proizvod.Naziv;
            txtSifra.Text = proizvod.Sifra;
            txtCijena.Text = proizvod.Cijena.ToString();
            if (proizvod.Slika != null)
            {
                MemoryStream ms = new MemoryStream();
                ms.Write(proizvod.Slika, 0, proizvod.Slika.Length);

                slikaBox.Image = Image.FromStream(ms);
            }
            cbxAktivan.Checked = proizvod.Status;

            HttpResponseMessage responseVrste = vrsteService.GetResponse();
            HttpResponseMessage responseJediniceMjere = jediniceMjereService.GetResponse();


            if (responseVrste.IsSuccessStatusCode)
            {

                List<VrsteProizvoda> vrste = responseVrste.Content.ReadAsAsync<List<VrsteProizvoda>>().Result;
                vrste.Insert(0, new VrsteProizvoda());
                vrsteList.DataSource = vrste;

                vrsteList.DisplayMember = "Naziv";
                vrsteList.ValueMember = "VrstaID";
               vrsteList.SelectedValue = proizvod.VrstaID;
               
                

            }

            if (responseJediniceMjere.IsSuccessStatusCode)
            {
                List<JediniceMjere> jedinice = responseJediniceMjere.Content.ReadAsAsync<List<JediniceMjere>>().Result;
                jedinice.Insert(0, new JediniceMjere());

                jedinicaMjereList.DataSource = jedinice;

                jedinicaMjereList.DisplayMember = "Naziv";
                jedinicaMjereList.ValueMember = "JedinicaMjereID";
                jedinicaMjereList.SelectedValue = proizvod.JedinicaMjereID;
            }

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                proizvod.VrstaID = Convert.ToInt32(vrsteList.SelectedValue);
                proizvod.Naziv = txtNaziv.Text;
                proizvod.Sifra = txtSifra.Text;
                proizvod.JedinicaMjereID = Convert.ToInt32(jedinicaMjereList.SelectedValue);
                proizvod.Cijena = Convert.ToDecimal(txtCijena.Text);
                proizvod.Status = cbxAktivan.Checked;



                HttpResponseMessage response = proizvodiService.PutActionResponse(proizvod.ProizvodID, proizvod);

                if (response.IsSuccessStatusCode)
                {

                    MessageBox.Show("Proizvod uspjesno izmijenjen!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {

                    MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                }
            }
        }




        private void vrsteList_Validating(object sender, CancelEventArgs e)
        {
            if (vrsteList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(vrsteList, Global.GetMessage("field_req"));
            }
            else
            {
                errorProvider.SetError(vrsteList, "");
            }
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

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNaziv.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Global.GetMessage("field_req"));
            }
            else
            {

                errorProvider.SetError(txtNaziv, "");
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtCijena.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCijena, Global.GetMessage("field_req"));
            }

            else
            {
                for (int i = 0; i < txtCijena.Text.Length; i++)
                {
                    if (!char.IsDigit(txtCijena.Text[i]) && !char.Equals(txtCijena.Text[i], ','))
                    {
                        e.Cancel = true;
                        errorProvider.SetError(txtCijena, Global.GetMessage("cijena_err"));

                        return;

                    }
                    else
                    {

                        errorProvider.SetError(txtSifra, "");
                    }


                }



            }

        }

        private void jedinicaMjereList_Validating(object sender, CancelEventArgs e)
        {
            if (jedinicaMjereList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(jedinicaMjereList, Global.GetMessage("field_req"));

            }
            else
            {

                errorProvider.SetError(jedinicaMjereList, "");

            }
        }

        private void txtCijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                               (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }




}
