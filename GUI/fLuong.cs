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
    public partial class fLuong : DevExpress.XtraEditors.XtraForm
    {
        public fLuong()
        {
            InitializeComponent();
            loadbangluong();
        }
        BindingSource luonglist = new BindingSource();
        void loaddsluong()
        {
            luonglist.DataSource = luongBUS.Instance.GetLuongnv();
            dgvluong.DataSource = luonglist;
        }
        void loadtencot()
        {
            dgvluong.Columns["maNV"].HeaderText = "Mã nhân viên";
            dgvluong.Columns["tenNV"].HeaderText = "Tên nhân viên";
            dgvluong.Columns["chucvu"].HeaderText = "Chức vụ";
            dgvluong.Columns["luong1ngay"].HeaderText = "Lương/ngày";
            dgvluong.Columns["songay"].HeaderText = "Số ngày";
            dgvluong.Columns["ngaynghi"].HeaderText = "Ngày vắng";
            dgvluong.Columns["phucap"].HeaderText = "Phụ cấp";
            dgvluong.Columns["diemchuyencan"].HeaderText = "Điểm TN";
            dgvluong.Columns["luong"].HeaderText = "Lương";
            dgvluong.Columns["maNV"].Width = 200;
            dgvluong.Columns["tenNV"].Width = 220;
            dgvluong.Columns["chucvu"].Width = 130;
            dgvluong.Columns["luong1ngay"].Width = 150;
            dgvluong.Columns["songay"].Width = 100;
            dgvluong.Columns["ngaynghi"].Width = 100;
            dgvluong.Columns["phucap"].Width = 140;
            dgvluong.Columns["diemchuyencan"].Width = 140;
            dgvluong.Columns["luong"].Width = 193;
            dgvluong.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        void addbingdingluong()
        {
            txtManv.DataBindings.Add(new Binding("Text",dgvluong.DataSource,"maNV",true,DataSourceUpdateMode.Never));
            txtLuongngay.DataBindings.Add(new Binding("Text", dgvluong.DataSource, "luong1ngay", true, DataSourceUpdateMode.Never));
            txtSongaylam.DataBindings.Add(new Binding("Text", dgvluong.DataSource, "songay", true, DataSourceUpdateMode.Never));
            txtNgaynghi.DataBindings.Add(new Binding("Text", dgvluong.DataSource, "ngaynghi", true, DataSourceUpdateMode.Never));
            txtPhucap.DataBindings.Add(new Binding("Text", dgvluong.DataSource, "phucap", true, DataSourceUpdateMode.Never));
            txtDcc.DataBindings.Add(new Binding("Text", dgvluong.DataSource, "diemchuyencan", true, DataSourceUpdateMode.Never));
            lbten.DataBindings.Add(new Binding("Text", dgvluong.DataSource, "tenNV", true, DataSourceUpdateMode.Never));
            lbchuvu.DataBindings.Add(new Binding("Text", dgvluong.DataSource, "chucvu", true, DataSourceUpdateMode.Never));
            lbluong.DataBindings.Add(new Binding("Text", dgvluong.DataSource, "luong", true, DataSourceUpdateMode.Never));
        }
        void loadbangluong()
        {
            loaddsluong();
            loadtencot();
            addbingdingluong();
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            loaddsluong();
        }
        bool checkluong_in_nhanvien()
        {
            foreach (NhanvienDTO item in NhanvienBUS.Instance.GetNhanvienList())
            {
                if (txtManv.Text == item.MaNV) return true;
            }
            return false;
        }
        bool checkluong_in_luong()
        {
            foreach (luongDTO item in luongBUS.Instance.GetLuongnv())
            {
                if (txtManv.Text == item.Manv)
                {
                    return true;
                }
            }
            return false;
        }
        bool checkdiemchuyencan(int a)
        {
            if (a < 0 || a > 10) return true;
            return false;
        }
        bool checkngaylam_ngaynghi(int a, int b)
        {
            if (a > 31 || a < 0 || b > 31 || b < 0) return true;
            return false;
        }
        bool checknhapthongtin()
        {
            if (txtManv.Text == "" || txtLuongngay.Text == "" || txtSongaylam.Text == "" || txtNgaynghi.Text == "" ||
                txtPhucap.Text == "" || txtDcc.Text == "")
            {
                return true;
            }
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checknhapthongtin())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkdiemchuyencan(Convert.ToInt32(txtDcc.Text))){
                MessageBox.Show("Chấm điểm chuyền cần từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkngaylam_ngaynghi(Convert.ToInt32(txtSongaylam.Text), Convert.ToInt32(txtNgaynghi.Text))){
                MessageBox.Show("Số ngày trong tháng hoặc số ngày nghỉ không được vượt quá 31 ngày!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (checkluong_in_luong())
            {
                MessageBox.Show("Lương nhân viên này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkluong_in_nhanvien())
            {
                MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn THÊM lương mới!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        int luongngay = Convert.ToInt32((txtLuongngay.Text.Replace(".", "")).Split(' ')[0]);
                        int phucap = Convert.ToInt32((txtPhucap.Text.Replace(".", "")).Split(' ')[0]);
                        luongBUS.Instance.themluongmoi(txtManv.Text, luongngay, Convert.ToInt32(txtSongaylam.Text),
                            Convert.ToInt32(txtNgaynghi.Text), phucap, Convert.ToInt32(txtDcc.Text));
                        loaddsluong();
                    }
                    catch { return; }
                }
            }
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (checknhapthongtin())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkdiemchuyencan(Convert.ToInt32(txtDcc.Text)))
            {
                MessageBox.Show("Chấm điểm chuyền cần từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkngaylam_ngaynghi(Convert.ToInt32(txtSongaylam.Text), Convert.ToInt32(txtNgaynghi.Text)))
            {
                MessageBox.Show("Số ngày trong tháng hoặc số ngày nghỉ không được vượt quá 31 ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkluong_in_nhanvien())
            {
                MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn CẬP NHẬT lương nhân viên!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        int luongngay = Convert.ToInt32((txtLuongngay.Text.Replace(".", "")).Split(' ')[0]);
                        int phucap = Convert.ToInt32((txtPhucap.Text.Replace(".", "")).Split(' ')[0]);
                        luongBUS.Instance.capnhatluong(txtManv.Text, luongngay, Convert.ToInt32(txtSongaylam.Text),
                            Convert.ToInt32(txtNgaynghi.Text), phucap, Convert.ToInt32(txtDcc.Text));
                        loaddsluong();
                    }
                    catch { return; }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == "")
            {
                MessageBox.Show("Chưa chọn tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkluong_in_nhanvien())
            {
                MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn XÓA lương nhân viên!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    luongBUS.Instance.xoaluong(txtManv.Text);
                    loaddsluong();
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            luonglist.DataSource = luongBUS.Instance.timtenhienthiinluong(txtTim.Text);
            dgvluong.DataSource = luonglist;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportLuong rpt = new ReportLuong();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
    }
}