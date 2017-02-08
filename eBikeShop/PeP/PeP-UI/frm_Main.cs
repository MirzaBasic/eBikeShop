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

namespace PeP_UI
{
    public partial class frm_Main : Form
    {

        WebApiHelper narudzbeService=new WebApiHelper("http://localhost:30455/", "api/Narudzbe");
        public frm_Main()
        {
            InitializeComponent();
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.frm_Korisnici form = new Users.frm_Korisnici();
            form.MdiParent = this;
           
            form.Show();

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

            HttpResponseMessage response = narudzbeService.GetActionResponse("GetBrojAktivnihNarudzbi");

            if (response.IsSuccessStatusCode) {
                int brojNarudzbi = response.Content.ReadAsAsync<int>().Result;
                if (brojNarudzbi > 0) {

                    notifyIcon.ShowBalloonTip(5000, "Nove narudžbe", "Broj aktivnih narudžbi: " + brojNarudzbi, ToolTipIcon.Info);
                }

            }
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products.frm_Proizvodi form = new Products.frm_Proizvodi();
            form.MdiParent = this;
            form.Show();
        }

        private void dobavljaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers.frm_Dobavljaci form = new Suppliers.frm_Dobavljaci();
            form.MdiParent = this;
            form.Show();
        }

        private void skladištaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Warehouses.frm_Skladista form = new Warehouses.frm_Skladista();
            form.MdiParent = this;
            form.Show();
        }

        private void narudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders.frm_Narudzbe form = new Orders.frm_Narudzbe();
            form.MdiParent = this;
            form.Show();
        }

        private void ulaziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inputs.frm_Ulazi form = new Inputs.frm_Ulazi();
            form.MdiParent = this;
            form.Show();
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            Orders.frm_Narudzbe frm = new Orders.frm_Narudzbe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void top10ProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportss.frmTop10ProizvodaReport frm = new Reportss.frmTop10ProizvodaReport();
            frm.Show();
        }

        private void oscilacijaProdajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportss.frmOscilacijeProizvodnjeReport frm = new Reportss.frmOscilacijeProizvodnjeReport();
            frm.Show();
        }
    }
}
