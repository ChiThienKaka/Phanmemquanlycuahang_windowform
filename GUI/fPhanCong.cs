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
    public partial class fPhanCong : DevExpress.XtraEditors.XtraForm
    {
        public fPhanCong()
        {
            InitializeComponent();
            loadBangPhancong();
        }
        BindingSource phanconglist = new BindingSource();
        void load()
        {
            phanconglist.DataSource = PhancongBUS.Instance.GetBangPhanConglist();
            dgvPhancong.DataSource = phanconglist;
        }
        void loadcot()
        {
            dgvPhancong.Columns["maNV"].HeaderText = "Mã nhân viên";
            dgvPhancong.Columns["tenNV"].HeaderText = "Tên nhân viên";
            dgvPhancong.Columns["chucvu"].HeaderText = "Chức vụ";
            dgvPhancong.Columns["nhiemvu"].HeaderText = "Nhiệm vụ";
            dgvPhancong.Columns["maNV"].Width = 200;
            dgvPhancong.Columns["tenNV"].Width = 200;
            dgvPhancong.Columns["chucvu"].Width = 200;
            dgvPhancong.Columns["nhiemvu"].Width = 775;
            dgvPhancong.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.8F, System.Drawing.FontStyle.Bold);
        }
        void addBinding()
        {
            txtMaNV.DataBindings.Add("Text", dgvPhancong.DataSource, "maNV", true, DataSourceUpdateMode.Never);
            txtNV.DataBindings.Add("Text", dgvPhancong.DataSource, "nhiemvu", true, DataSourceUpdateMode.Never);
        }
        void loadBangPhancong()
        {
            load();
            loadcot();
            addBinding();
        }
        bool checknhapthongtin()
        {
            if (txtMaNV.Text == "" || txtNV.Text == "") return true;
            return false;
        }
        bool checkManv_Nhanvien()
        {
            foreach (NhanvienDTO item in NhanvienBUS.Instance.GetNhanvienList())
            {
                if (item.MaNV == txtMaNV.Text) return true;
            }
            return false;
        }
        bool checkManv_Phancong()
        {
            foreach (PhancongDTO item in PhancongBUS.Instance.GetBangPhanConglist())
            {
                if (item.MaNV == txtMaNV.Text) return true;
            }
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checknhapthongtin())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkManv_Nhanvien())
            {
                MessageBox.Show("Không tìm thấy nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkManv_Phancong())
            {
                MessageBox.Show("Nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn THÊM nhiệm vụ mới!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    PhancongBUS.Instance.ThemPhanCong(txtMaNV.Text, txtNV.Text);
                    load();
                }
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (checknhapthongtin())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkManv_Nhanvien())
            {
                MessageBox.Show("Không tìm thấy nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn CẬP NHẬT nhiệm vụ này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    PhancongBUS.Instance.CapnhatPhanCong(txtMaNV.Text, txtNV.Text);
                    load();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text=="")
            {
                MessageBox.Show("Chưa chọn nhiệm vụ cần XÓA!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkManv_Nhanvien())
            {
                MessageBox.Show("Không tìm thấy nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn XÓA nhiệm vụ này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    PhancongBUS.Instance.XoaPhanCong(txtMaNV.Text);
                    load();
                }
            }
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            phanconglist.DataSource = PhancongBUS.Instance.TimPhanCong(txtTim.Text);
            dgvPhancong.DataSource = phanconglist;
        }
    }
}