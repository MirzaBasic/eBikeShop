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
    public partial class frmTop10ProizvodaReport : Form
    {
        public frmTop10ProizvodaReport()
        {
            InitializeComponent();
        }

        private void frmTop10ProizvodaReport_Load(object sender, EventArgs e)
        {
            Top10Proizvodi dsProizvodi = new Top10Proizvodi();
            Top10ProizvodiTableAdapters.Top10ProizvodaTableAdapter adapter = new Top10ProizvodiTableAdapters.Top10ProizvodaTableAdapter();
            adapter.Fill(dsProizvodi.Top10Proizvoda);
            bindingSource.DataSource = dsProizvodi.Top10Proizvoda;
            ReportDataSource rds = new ReportDataSource("Proizvodi",bindingSource);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
