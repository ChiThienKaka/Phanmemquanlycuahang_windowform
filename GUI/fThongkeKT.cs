using BUS;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fThongkeKT : DevExpress.XtraEditors.XtraForm
    {
        public fThongkeKT()
        {
            InitializeComponent();
            Resetngay();
        }
        void Resetngay()
        {
            DateTime today = DateTime.Now;
            dateNgayvao.EditValue = new DateTime(today.Year,today.Month,1);
            dateNgayra.EditValue = Convert.ToDateTime(dateNgayvao.EditValue).AddMonths(1).AddDays(-1);
        }
        int i = 0;
        private void btnThongke_Click(object sender , EventArgs e)
        {
            if (i == 1)
            {
                i = 0;
                chart1.Series["Tổng tiền"].Points.Clear();
            }
            DataTable data = DoanhthutheongayktBUS.Instance.Doanhthutheongay(Convert.ToDateTime(dateNgayvao.EditValue), Convert.ToDateTime(dateNgayra.EditValue));
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tiền(VNĐ)";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.Series["Tổng tiền"]["DrawingStyle"] = "Cylinder";
            chart1.Series["Tổng tiền"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DateTime ngay = Convert.ToDateTime(data.Rows[i]["ngayra"]);
                ngay.ToString("dd,MM,yyyy");
                chart1.Series["Tổng tiền"].Points.AddXY(ngay.ToString("dd-MM-yyyy"), data.Rows[i]["tong"]);
            }
            i++;
        }

        private void btnThongke1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                i = 0;
                chart1.Series["Tổng tiền"].Points.Clear();
            }
            DataTable data = DoanhthutheongayktBUS.Instance.Doanhthutheongay(Convert.ToDateTime(dateNgayvao.EditValue), Convert.ToDateTime(dateNgayra.EditValue));
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tiền(VNĐ)";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.Series["Tổng tiền"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DateTime ngay = Convert.ToDateTime(data.Rows[i]["ngayra"]);
                ngay.ToString("dd,MM,yyyy");
                chart1.Series["Tổng tiền"].Points.AddXY(ngay.ToString("dd-MM-yyyy"), data.Rows[i]["tong"]);
            }
            i++;
        }

        private void btnBDT_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                i = 0;
                chart1.Series["Tổng tiền"].Points.Clear();
            }
            DataTable data = DoanhthutheongayktBUS.Instance.Doanhthutheongay(Convert.ToDateTime(dateNgayvao.EditValue), Convert.ToDateTime(dateNgayra.EditValue));
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tiền(VNĐ)";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.Series["Tổng tiền"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DateTime ngay = Convert.ToDateTime(data.Rows[i]["ngayra"]);
                ngay.ToString("dd,MM,yyyy");
                chart1.Series["Tổng tiền"].Points.AddXY(ngay.ToString("dd-MM-yyyy"), data.Rows[i]["tong"]);
            }
            i++;
        }
    }
}