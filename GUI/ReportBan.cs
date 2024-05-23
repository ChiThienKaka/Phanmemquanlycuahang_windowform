using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI
{
    public partial class ReportBan : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBan()
        {
            InitializeComponent();
            loadngay();
        }
        void loadngay()
        {
            DateTime date = DateTime.Now;
            xrLabel2.Text = "Bình dương, " + "Ngày " + date.Day.ToString() + " tháng " + date.Month.ToString() + " năm " + date.Year.ToString();
        }
    }
}
