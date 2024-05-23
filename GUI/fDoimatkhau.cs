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
    public partial class fDoimatkhau : DevExpress.XtraEditors.XtraForm
    {
        string taikhoan;
        public fDoimatkhau(string taikhoan)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool checkMK()
        {
            List<TaikhoanDTO> dstk = TaikhoanBUS.Instance.DangNhap();
            foreach (TaikhoanDTO item in dstk)
            {
                if (String.Compare(item.Taikhoan, taikhoan, false) == 0 && String.Compare(item.Matkhau,txtMatKhauHT.Text, false) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMatKhauHT.Text == "" || txtMKmoi.Text == "" || txtNhaplai.Text == "")
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMKmoi.Text != txtNhaplai.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkMK())
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaikhoanBUS.Instance.Doitaikhoanmatkhau(taikhoan, txtMKmoi.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}