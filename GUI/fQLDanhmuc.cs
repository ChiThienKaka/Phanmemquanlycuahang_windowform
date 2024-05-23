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
    public partial class fQLDanhmuc : DevExpress.XtraEditors.XtraForm
    {
        public fQLDanhmuc()
        {
            InitializeComponent();
            loadbangDanhmuc();
        }
        BindingSource Danhmuclist = new BindingSource();
        void loaddanhmuc()
        {
            Danhmuclist.DataSource = DanhmucBUS.Instance.GetDSDanhmuc();
            dgvDanhmuc.DataSource = Danhmuclist;
        }
        void addbindingdanhmuc()
        {
            txtMDM.DataBindings.Add(new Binding("Text", dgvDanhmuc.DataSource, "maDM", true, DataSourceUpdateMode.Never));
            txtTenDM.DataBindings.Add(new Binding("Text", dgvDanhmuc.DataSource, "tenDM", true, DataSourceUpdateMode.Never));
        }
        void loadcot()
        {
            dgvDanhmuc.Columns["maDM"].HeaderText = "Mã danh mục";
            dgvDanhmuc.Columns["tenDM"].HeaderText = "Tên danh mục";
            dgvDanhmuc.ColumnHeadersDefaultCellStyle.Font= new System.Drawing.Font("Tahoma", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        void loadbangDanhmuc()
        {
            loaddanhmuc();
            addbindingdanhmuc();
            loadcot();
        }
        bool checkMaDM_Danhmuc()
        {
            foreach (DanhmucDTO item in DanhmucBUS.Instance.GetDSDanhmuc())
            {
                if (Convert.ToInt32(txtMDM.Text) == item.MaDM) return true;
            }
            return false;
        }
        int checkmaDM()
        {
            int madm;
            Int32.TryParse(txtMDM.Text, out madm);
            return madm;
        }
        bool checknhapthongtin()
        {
            if (txtMDM.Text == "" || txtTenDM.Text == "") return true;
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checknhapthongtin())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkmaDM() == 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkMaDM_Danhmuc())
            {
                MessageBox.Show("Mã danh mục đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc muốn THÊM danh mục mới!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    DanhmucBUS.Instance.themDanhmuc(Convert.ToInt32(txtMDM.Text), txtTenDM.Text);
                    loaddanhmuc();
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
            if (checkmaDM() == 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkMaDM_Danhmuc())
            {
                MessageBox.Show("Mã danh mục không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn CẬP NHẬT danh mục!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    DanhmucBUS.Instance.Capnhatdanhmuc(Convert.ToInt32(txtMDM.Text), txtTenDM.Text);
                    loaddanhmuc();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMDM.Text == "")
            {
                MessageBox.Show("Chưa chọn tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkMaDM_Danhmuc())
            {
                MessageBox.Show("Mã danh mục không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn XÓA danh mục này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    DanhmucBUS.Instance.Xoadanhmuc(Convert.ToInt32(txtMDM.Text));
                    loaddanhmuc();
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvDanhmuc.DataSource= DanhmucBUS.Instance.GetTimdanhmuc(txtTim.Text);
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            loaddanhmuc();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportDanhmuc rpt = new ReportDanhmuc();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
    }
}