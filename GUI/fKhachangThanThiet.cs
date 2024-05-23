using BUS;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fKhachangThanThiet : DevExpress.XtraEditors.XtraForm
    {
        public fKhachangThanThiet()
        {
            InitializeComponent();
            loadbangKhachhang();
            loadcot();
        }
        void loadbangKhachhang()
        {
            dgvKhachhangthanthiet.DataSource = KhachHangTTBUS.Instance.BangKhangHangTT();
        }
        void loadcot()
        {
            dgvKhachhangthanthiet.Columns["MaKH"].HeaderText = "Mã Nhân viên";
            dgvKhachhangthanthiet.Columns["tenKH"].HeaderText = "Tên khách hàng";
            dgvKhachhangthanthiet.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvKhachhangthanthiet.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvKhachhangthanthiet.Columns["Hinhanh"].HeaderText = "Hình Ảnh";
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvKhachhangthanthiet.Columns[4];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvKhachhangthanthiet.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.8F, System.Drawing.FontStyle.Bold);
        }
        byte[] ImagetoByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmp;*.png";//đuôi file để mở ảnh
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pBHinhanh.ImageLocation = openFileDialog.FileName;
            }
        }
        bool checkMaKh_KHTT()
        {
            foreach (DataRow item in KhachHangTTBUS.Instance.BangKhangHangTT().Rows)
            {
                if (item["MaKH"].ToString() == txtMaKH.Text)
                {
                    return true;
                }
            }
            return false;
        }
        bool checkdienthongtin()
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtSDT.Text == "" || txtDc.Text == "") return true;
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkdienthongtin())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pBHinhanh.ImageLocation == null)
            {
                MessageBox.Show("Chưa chọn ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkMaKh_KHTT())
            {
                MessageBox.Show("Khách hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc muốn THÊM Khách hàng thân thiết mới!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    KhachHangTTBUS.Instance.ThemKhachHang(txtMaKH.Text, txtTenKH.Text, txtDc.Text, txtSDT.Text, ImagetoByteArray(pBHinhanh));
                    loadbangKhachhang();
                }
            }
        }

        private void dgvKhachhangthanthiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKhachhangthanthiet.SelectedRows[0].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachhangthanthiet.SelectedRows[0].Cells[1].Value.ToString();
            txtDc.Text = dgvKhachhangthanthiet.SelectedRows[0].Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachhangthanthiet.SelectedRows[0].Cells[3].Value.ToString();
            try
            {
                if(dgvKhachhangthanthiet.SelectedRows[0].Cells[4].Value == DBNull.Value)
                {
                    return;
                }
                if (dgvKhachhangthanthiet.SelectedRows[0].Cells[4].ToString() != "")
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])dgvKhachhangthanthiet.SelectedRows[0].Cells[4].Value);
                    pBHinhanh.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    pBHinhanh.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (checkdienthongtin())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pBHinhanh.ImageLocation == null)
            {
                MessageBox.Show("Chưa chọn ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkMaKh_KHTT())
            {
                MessageBox.Show("Không tìm thấy khách hàng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn CẬP NHẬT Khách hàng thân thiết này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    KhachHangTTBUS.Instance.CapnhatKhachHang(txtMaKH.Text, txtTenKH.Text, txtDc.Text, txtSDT.Text, ImagetoByteArray(pBHinhanh));
                    loadbangKhachhang();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Chưa chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkMaKh_KHTT())
            {
                MessageBox.Show("Không tìm thấy khách hàng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn XÓA Khách hàng thân thiết này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    KhachHangTTBUS.Instance.XoaKhachHang(txtMaKH.Text);
                    loadbangKhachhang();
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                MessageBox.Show("Nhập số điện thoại cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                dgvKhachhangthanthiet.DataSource= KhachHangTTBUS.Instance.BangTimSDT(txtTim.Text);
            }
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            loadbangKhachhang();
        }
    }
}