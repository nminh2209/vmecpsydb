using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Windows.Forms;

namespace EESSP
{
    public partial class ReportsForm : Form
    {
        public ReportsForm(ReportClass report)
        {
            InitializeComponent();
            crystalReportViewerReports.ReportSource = report;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
