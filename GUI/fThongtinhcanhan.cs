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
    public partial class fThongtinhcanhan : DevExpress.XtraEditors.XtraForm
    {
        public fThongtinhcanhan(string taikhoan)
        {
            InitializeComponent();
            load(taikhoan);
        }
        void load(string taikhoan)
        {
            foreach (DataRow item in NhanvienBUS.Instance.GetNV_ToTK(taikhoan).Rows)
            {
                txtTaikhoan.Text = item["taikhoan"].ToString();
                txtTennhanvien.Text = item["tenNV"].ToString();
                txtChucvu.Text = item["chucvu"].ToString();
                txtDiachi.Text = item["diachi"].ToString();
                txtEmail.Text = item["email"].ToString();
                txtSDT.Text = item["sdt"].ToString();
                break;
            }
        }

        private void btnDoiMk_Click(object sender, EventArgs e)
        {
            fDoimatkhau f = new fDoimatkhau(txtTaikhoan.Text);
            f.ShowDialog();
        }
    }
}