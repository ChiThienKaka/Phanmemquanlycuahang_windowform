using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI
{
    public partial class ReportNhanvien : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportNhanvien()
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
