using BUS;
using DevExpress.XtraEditors;
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
    public partial class fDangnhap : DevExpress.XtraEditors.XtraForm
    {
        public fDangnhap()
        {
            InitializeComponent();
        }
        public static string taikhoan;
        bool checkloaitk()
        {
            List<TaikhoanDTO> dstk = TaikhoanBUS.Instance.DangNhap();
            foreach (TaikhoanDTO item in dstk)
            {
                if (String.Compare(item.Taikhoan, txtTK.Text, false) == 0 && String.Compare(item.Matkhau, txtMK.Text, false) == 0)
                {
                    if(item.LoaiTK==0) return true;
                }
            }
            return false;
        }
        bool checkDangnhap()
        {
            List<TaikhoanDTO> dstk = TaikhoanBUS.Instance.DangNhap();
            foreach (TaikhoanDTO item in dstk)
            {
                if (String.Compare(item.Taikhoan, txtTK.Text, false) == 0 && String.Compare(item.Matkhau, txtMK.Text, false) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "" || txtMK.Text == "")
            {
                MessageBox.Show("Chưa nhập tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkDangnhap())
            {
                taikhoan = txtTK.Text;
                this.Close();
                if (checkloaitk()) fTrangchu.loaitk = true;
                fTrangchu.checkdangnhap = true;
                floading ld = new floading();
                ld.FormClosing += Ld_FormClosing;
                ld.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Text = "";txtMK.Text = "";
                txtTK.Focus();
                return;
            }
        }

        private void Ld_FormClosing(object sender, FormClosingEventArgs e)
        {
            fPhongcho fpc = new fPhongcho();
            fpc.ShowDialog();
        }

        private void checkHTMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHTMK.Checked == true)  txtMK.Properties.UseSystemPasswordChar = false;
            else txtMK.Properties.UseSystemPasswordChar = true;
        }
    }
}