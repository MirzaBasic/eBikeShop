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
using System.IO;
using System.Configuration;

namespace PeP_UI.Products
{
    public partial class frm_Proizvodi : Form
    {

        WebApiHelper vrsteService = new WebApiHelper("http://localhost:30455/", "api/VrsteProizvoda");
        WebApiHelper jediniceMjereService = new WebApiHelper("http://localhost:30455/", "api/JediniceMjere");
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:30455/", "api/Proizvodi");
        Proizvodi proizvod = new Proizvodi();
        public frm_Proizvodi()
        {
            InitializeComponent();
        }

        private void frm_Proizvodi_Load(object sender, EventArgs e)
        {


            BindForm();
            BindGrid();

        }

        private void BindGrid()
        {
            HttpResponseMessage responseProizvodi = proizvodiService.GetActionResponse("SearchProizvodiNazivVrsta",Convert.ToInt32(vrstePretragaList.SelectedValue),txtNazivSifra.Text.Trim());

            if (responseProizvodi.IsSuccessStatusCode)
            {
                dgProizvodi.AutoGenerateColumns = false;
                dgProizvodi.DataSource = responseProizvodi.Content.ReadAsAsync<List<Proizvodi_Result>>().Result;
               
               
                

            }

            else
            {


                MessageBox.Show("Error: " + responseProizvodi.StatusCode + Environment.NewLine + "Message: " + responseProizvodi.ReasonPhrase);
            }
        }

        private void BindForm()
        {

            HttpResponseMessage responseVrste1 = vrsteService.GetResponse();
            HttpResponseMessage responseVrste2 = vrsteService.GetResponse();
            HttpResponseMessage responseJediniceMjere = jediniceMjereService.GetResponse();
          


            if (responseVrste1.IsSuccessStatusCode&&responseVrste2.IsSuccessStatusCode)
            {
                List<VrsteProizvoda> vrste1 = responseVrste1.Content.ReadAsAsync<List<VrsteProizvoda>>().Result;
                List<VrsteProizvoda> vrste2 = responseVrste2.Content.ReadAsAsync<List<VrsteProizvoda>>().Result;
                vrste1.Insert(0, new VrsteProizvoda());
                vrste2.Insert(0, new VrsteProizvoda());
                vrsteList.DataSource = vrste1;
                vrstePretragaList.DataSource = vrste2;

                vrsteList.DisplayMember = "Naziv";
                vrsteList.ValueMember = "VrstaID";

                vrstePretragaList.DisplayMember = "Naziv";
                vrstePretragaList.ValueMember = "VrstaID";
                cbxAktivan.Checked = true;

            }

            else
            {


                MessageBox.Show("Error: " + responseVrste1.StatusCode + Environment.NewLine + "Message: " + responseVrste1.ReasonPhrase);
            }


            if (responseJediniceMjere.IsSuccessStatusCode)
            {
                List<JediniceMjere> jedinice = responseJediniceMjere.Content.ReadAsAsync<List<JediniceMjere>>().Result;
                jedinice.Insert(0, new JediniceMjere());

                jedinicaMjereList.DataSource = jedinice;
                
                jedinicaMjereList.DisplayMember = "Naziv";
                jedinicaMjereList.ValueMember = "JedinicaMjereID";
            }
            else
            {


                MessageBox.Show("Error: " + responseJediniceMjere.StatusCode + Environment.NewLine + "Message: " + responseJediniceMjere.ReasonPhrase);
            }

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

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren()) { 
            proizvod.VrstaID=Convert.ToInt32(vrsteList.SelectedValue);
            proizvod.Naziv = txtNaziv.Text;
            proizvod.Sifra = txtSifra.Text;
            proizvod.JedinicaMjereID = Convert.ToInt32(jedinicaMjereList.SelectedValue);
            proizvod.Cijena = Convert.ToDecimal(txtCijena.Text);
            proizvod.Status = Convert.ToBoolean(cbxAktivan.CheckState);
            HttpResponseMessage response = proizvodiService.PostResponse(proizvod);
        
                if (response.IsSuccessStatusCode)
                {


                    MessageBox.Show("Proizvod " + proizvod.Naziv + " uspješno dodan!");
                    BindForm();
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
            txtNaziv.Text = txtCijena.Text = txtSifra.Text = txtSlika.Text = "";
            vrsteList.SelectedIndex = 0;
            jedinicaMjereList.SelectedIndex = 0;
            slikaBox.Image = null;
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
           
            HttpResponseMessage response=proizvodiService.GetResponse(Convert.ToInt32(dgProizvodi.SelectedRows[0].Cells[0].Value));
            if(response.IsSuccessStatusCode){
                Proizvodi p=response.Content.ReadAsAsync<Proizvodi>().Result;
                frm_ProizvodiUredi frm = new frm_ProizvodiUredi(p);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    txtNazivSifra.Text = "";
                    BindGrid();
                }

            }

            else
            {

                MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);

            }

        }

        private void slikaBox_Click(object sender, EventArgs e)
        {

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
    }
}
