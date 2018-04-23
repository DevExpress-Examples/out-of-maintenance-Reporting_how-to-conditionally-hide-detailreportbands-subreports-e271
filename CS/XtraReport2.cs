using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Rep3
{
    public partial class XtraReport2 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport2()
        {
            InitializeComponent();
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Create the detail report 
            SubReport reportProducts = xrSubreport1.ReportSource as SubReport;

            // Pass the CategoryID parameter from the master report.
            reportProducts.CategoryID = (int)this.GetCurrentColumnValue("CategoryID");

            if (reportProducts.CategoryID % 2 == 1)
                e.Cancel = true;

        }

    }
}
