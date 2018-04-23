using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace Rep3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraReport1 rp1 = new XtraReport1();

            new ReportPrintTool(rp1).ShowPreviewDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XtraReport2 rp2 = new XtraReport2();

            new ReportPrintTool(rp2).ShowPreviewDialog();
        }
    }
}