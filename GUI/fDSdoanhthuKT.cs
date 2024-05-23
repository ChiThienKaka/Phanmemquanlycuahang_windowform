using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DTO;
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
    public partial class fDSdoanhthuKT : DevExpress.XtraEditors.XtraForm
    {
        public fDSdoanhthuKT()
        {
            InitializeComponent();
            loaddoanhthu();
            loadcot();
        }
        void loadcot()
        {
            dgvDoanhthuct.Columns["Id"].HeaderText="Mã HĐ";
            dgvDoanhthuct.Columns["ngayvao"].HeaderText = "Ngày vào";
            dgvDoanhthuct.Columns["ngayra"].HeaderText = "Ngày ra";
            dgvDoanhthuct.Columns["idban"].HeaderText = "Số bàn";
            dgvDoanhthuct.Columns["tendanhmuc"].HeaderText = "Tên danh mục";
            dgvDoanhthuct.Columns["tenmon"].HeaderText = "Tên món";
            dgvDoanhthuct.Columns["soluong"].HeaderText = "Số lượng";
            dgvDoanhthuct.Columns["giamgia"].HeaderText = "Giảm giá";
            dgvDoanhthuct.Columns["tongtien"].HeaderText = "Tổng tiền";
            dgvDoanhthuct.Columns["trangthai"].HeaderText = "Trạng thái";
            dgvDoanhthuct.Columns["Id"].Width = 110;
            dgvDoanhthuct.Columns["ngayvao"].Width = 140;
            dgvDoanhthuct.Columns["ngayra"].Width = 140;
            dgvDoanhthuct.Columns["idban"].Width =140;
            dgvDoanhthuct.Columns["tendanhmuc"].Width =230;
            dgvDoanhthuct.Columns["tenmon"].Width =320;
            dgvDoanhthuct.Columns["soluong"].Width =140;
            dgvDoanhthuct.Columns["giamgia"].Width =140;
            dgvDoanhthuct.Columns["tongtien"].Width =190;
            dgvDoanhthuct.Columns["trangthai"].Width =150;
            dgvDoanhthuct.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        void loaddoanhthu()
        {
            dgvDoanhthuct.DataSource = DoanhthuctBUS.Instance.Getdoanhthuchitiet();
            label2.Text = "Số dòng: " + dgvDoanhthuct.Rows.Count.ToString();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            loaddoanhthu();
        }
        private void btnHddtt_Click(object sender, EventArgs e)
        {
            dgvDoanhthuct.DataSource = DoanhthuctBUS.Instance.GetDoanhthudathanhtoanroi();
            label2.Text = "Số dòng: " + dgvDoanhthuct.Rows.Count.ToString();
        }

        private void btnHdctt_Click(object sender, EventArgs e)
        {
            dgvDoanhthuct.DataSource = DoanhthuctBUS.Instance.Getdoanhthuchuaduocthanhtoan();
            label2.Text = "Số dòng: " + dgvDoanhthuct.Rows.Count.ToString();
        }

        private void ReportDT_Click(object sender, EventArgs e)
        {
            ReportDoanhThuct rpt = new ReportDoanhThuct();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
    }
}