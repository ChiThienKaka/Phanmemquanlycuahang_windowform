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
    public partial class fTaikhoan : DevExpress.XtraEditors.XtraForm
    {
        public fTaikhoan()
        {
            InitializeComponent();
            loadtaikhoanlen();
        }
        void loadcot()
        {
            dgvTaikhoan.Columns["taikhoan"].HeaderText = "Tài khoản";
            dgvTaikhoan.Columns["tenhienthi"].HeaderText = "Tên hiển thị";
            dgvTaikhoan.Columns["matkhau"].HeaderText = "Mật khẩu";
            dgvTaikhoan.Columns["loaiTK"].HeaderText = "Loại tài khoản";
            dgvTaikhoan.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        void addBindingsTaikhoan()
        {
            txtTK.DataBindings.Add(new Binding("Text", dgvTaikhoan.DataSource, "taikhoan", true, DataSourceUpdateMode.Never));
            txtTHT.DataBindings.Add(new Binding("Text", dgvTaikhoan.DataSource, "tenhienthi", true, DataSourceUpdateMode.Never));
            txtMK.DataBindings.Add(new Binding("Text", dgvTaikhoan.DataSource, "matkhau", true, DataSourceUpdateMode.Never));
            txtLTK.DataBindings.Add(new Binding("Text", dgvTaikhoan.DataSource, "loaiTK", true, DataSourceUpdateMode.Never));
        }
        void loadtaikhoan()
        {
            taikhoanlist.DataSource = TaikhoanBUS.Instance.DangNhap();
            dgvTaikhoan.DataSource = taikhoanlist;
        }
        BindingSource taikhoanlist = new BindingSource();
        void loadtaikhoanlen()
        {
            loadtaikhoan();
            loadcot();
            addBindingsTaikhoan();
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtTK.Text=="")
            {
                MessageBox.Show("Chưa chọn tài khoản!","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn cập nhật tài khoản này không!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                TaikhoanBUS.Instance.Capnhattaikhoan(txtTK.Text, txtTHT.Text, txtMK.Text, Convert.ToInt32(txtLTK.Text));
            }
            loadtaikhoan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "")
            {
                MessageBox.Show("Chưa chọn tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không!","Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK){
                TaikhoanBUS.Instance.Xoataikhoan(txtTK.Text);
            }
            loadtaikhoan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "" || txtTHT.Text == "" || txtMK.Text == "" || txtLTK.Text == "")
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach ( TaikhoanDTO item in TaikhoanBUS.Instance.DangNhap())
            {
                if (txtTK.Text == item.Taikhoan)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            TaikhoanBUS.Instance.ThemTaikhoan(txtTK.Text,txtTHT.Text,txtMK.Text,Convert.ToInt32(txtLTK.Text));
            loadtaikhoan();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            taikhoanlist.DataSource = TaikhoanBUS.Instance.Timtaikhoan(txtTim.Text);
            dgvTaikhoan.DataSource = taikhoanlist;
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            loadtaikhoan();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportTaikhoan rpt = new ReportTaikhoan();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
    }
}