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
    public partial class fNhanvien : DevExpress.XtraEditors.XtraForm
    {
        public fNhanvien()
        {
            InitializeComponent();
            loaddsnhanvien();
        }
        BindingSource nhanvienList = new BindingSource();
        void loadcot()
        {
            dgvNhanvien.Columns["maNV"].HeaderText = "Mã nhân viên";
            dgvNhanvien.Columns["tenNV"].HeaderText = "Tên nhân viên";
            dgvNhanvien.Columns["chucvu"].HeaderText = "Chức vụ";
            dgvNhanvien.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvNhanvien.Columns["email"].HeaderText = "Email";
            dgvNhanvien.Columns["sdt"].HeaderText = "Số điện thoại";
            dgvNhanvien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        void loadnhanvien()
        {
            nhanvienList.DataSource = NhanvienBUS.Instance.GetNhanvienList();
            dgvNhanvien.DataSource = nhanvienList;
        }
        void addBindingsNhanvien()
        {
            txtmaNV.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "maNV", true, DataSourceUpdateMode.Never));
            txttNV.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "tenNV", true, DataSourceUpdateMode.Never));
            txtCV.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "chucvu", true, DataSourceUpdateMode.Never));
            txtDC.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "diachi", true, DataSourceUpdateMode.Never));
            txtemail.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "email", true, DataSourceUpdateMode.Never));
            txtSdt.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "sdt", true, DataSourceUpdateMode.Never));
        }
        bool checkmanv()
        {
            foreach (NhanvienDTO item in NhanvienBUS.Instance.GetNhanvienList())
            {
                if (item.MaNV == txtmaNV.Text) return false;
            }
            return true;
        }
        bool checkmanvtrongtaikhoan()
        {
            foreach (TaikhoanDTO item in TaikhoanBUS.Instance.DangNhap())
            {
                if (txtmaNV.Text == item.Taikhoan) return true;
            }
            return false;
        }
        bool thongbaonhapthieu()
        {
            if (txtmaNV.Text == "" || txttNV.Text == "" || txtCV.Text == "" || txtDC.Text == "" ||
                txtemail.Text == "" || txtSdt.Text == "")
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!thongbaonhapthieu()) return;
            if (!checkmanvtrongtaikhoan())
            {
                MessageBox.Show("Mã nhân viên không tồn tài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (!checkmanv())
                {
                    MessageBox.Show("Nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                NhanvienBUS.Instance.Themnhanvien(txtmaNV.Text, txttNV.Text, txtCV.Text, txtDC.Text, txtemail.Text,
                    txtSdt.Text);
            }
            loadnhanvien();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!thongbaonhapthieu()) return;
            if (checkmanv())
            {
                MessageBox.Show("Mã nhân viên không tồn tại!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Question);
                return;
            }
            if(MessageBox.Show("Bạn có chắc muốn CẬP NHẬT nhân viên này!","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                NhanvienBUS.Instance.capnhatnhanvien(txtmaNV.Text, txttNV.Text, txtCV.Text, txtDC.Text, txtemail.Text, txtSdt.Text);
            }
            loadnhanvien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtmaNV.Text == "")
            {
                MessageBox.Show("Chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkmanv())
            {
                MessageBox.Show("Nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn XÓA nhân viên này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                NhanvienBUS.Instance.xoanhanvien(txtmaNV.Text);
            }
            loadnhanvien();
        }
        void loaddsnhanvien()
        {
            loadnhanvien();
            loadcot();
            addBindingsNhanvien();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            nhanvienList.DataSource = NhanvienBUS.Instance.Gettimnhanvien(txtTim.Text);
            dgvNhanvien.DataSource = nhanvienList;
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            loadnhanvien();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportNhanvien rpt = new ReportNhanvien();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
    }
}