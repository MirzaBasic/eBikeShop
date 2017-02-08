using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeP_UI.Reportss
{
    public partial class frmOscilacijeProizvodnjeReport : Form
    {
        public frmOscilacijeProizvodnjeReport()
        {
            InitializeComponent();
        }

        private void frmOscilacijeProizvodnjeReport_Load(object sender, EventArgs e)
        {
            OscilacijeProdaje dsProdaja = new OscilacijeProdaje();
            OscilacijeProdajeTableAdapters.PoslovanjeGodineMjeseciTableAdapter adapter = new OscilacijeProdajeTableAdapters.PoslovanjeGodineMjeseciTableAdapter();
            adapter.Fill(dsProdaja.PoslovanjeGodineMjeseci);
            bindingSource.DataSource = dsProdaja.PoslovanjeGodineMjeseci;
            ReportDataSource rds = new ReportDataSource("OscilacijeProdaje", bindingSource);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
