using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Rep3
{
    public partial class SubReport : DevExpress.XtraReports.UI.XtraReport
    {
        public SubReport()
        {
            InitializeComponent();
        }

        int catid;

        public int CategoryID
        {
            get { return catid; }
            set { catid= value; }
        }

        private void SubReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.productsTableAdapter.FillBy(nwindDataSet1.Products, (int?)CategoryID);
        }

    }
}
