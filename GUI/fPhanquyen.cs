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
    public partial class fPhanquyen : DevExpress.XtraEditors.XtraForm
    {
        public fPhanquyen()
        {
            InitializeComponent();
        }
        void OpenForm(Type typeForm)
        {//kiểm tra xem form đã hoạt động chưa
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }

        private void btnTKdth_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(fThongkeKT));
        }

        private void btnDoanhthuchitiet_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(fDSdoanhthuKT));
        }

        private void btntaikhoan_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(fNhanvien));
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(fTaikhoan));
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(fLuong));
        }

        private void btndmuc_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(fQLDanhmuc));
        }

        private void btnmonan_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(fQLMonan));
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(fQLCTThucan));
        }

        private void btnban_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(fQLBan));
        }

        private void btnGiaoviec_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(fPhanCong));
        }

        private void btnKHTT_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(fKhachangThanThiet));
        }
    }
}