using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fQLMonan : DevExpress.XtraEditors.XtraForm
    {
        public fQLMonan()
        {
            InitializeComponent();
            loadbangmonan();
        }
        BindingSource monanlist = new BindingSource();
        bool checkMamon_Monan()
        {
            foreach (QLThucanDTO item in ThucanBUS.Instance.QLThucan())
            {
                if (item.Id == Convert.ToInt32(txtMamon.Text)) return true;
            }
            return false;
        }
        bool checktenmon_Tenmon()
        {
            foreach (QLThucanDTO item in ThucanBUS.Instance.QLThucan())
            {
                if (item.Tenmon == txtTenmon.Text) return true;
            }
            return false;
        }
        bool checkMadm_Danhmuc()
        {
            foreach (DanhmucDTO item in DanhmucBUS.Instance.GetDSDanhmuc())
            {
                if (item.MaDM == Convert.ToInt32(txtMadm.Text)) return true;
            }
            return false;
        }
        bool checknhapthongtin()
        {
            if (txtMamon.Text == "" || txtTenmon.Text == "" || txtMadm.Text == "" || txtGia.Text == "") return true;
            return false;
        }
        void loadmonan()
        {
            monanlist.DataSource= ThucanBUS.Instance.QLThucan();
            dgvMonan.DataSource = monanlist;
        }
        void addbindingmonan()
        {
            txtMamon.DataBindings.Add(new Binding("Text", dgvMonan.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtTenmon.DataBindings.Add(new Binding("Text", dgvMonan.DataSource, "tenmon", true, DataSourceUpdateMode.Never));
            txtMadm.DataBindings.Add(new Binding("Text", dgvMonan.DataSource, "iddanhmuc", true, DataSourceUpdateMode.Never));
            txtGia.DataBindings.Add(new Binding("Text", dgvMonan.DataSource, "gia", true, DataSourceUpdateMode.Never));
        }
        void loadcot()
        {
            dgvMonan.Columns["id"].HeaderText = "Mã món ăn";
            dgvMonan.Columns["tenmon"].HeaderText = "Tên món";
            dgvMonan.Columns["iddanhmuc"].HeaderText = "Mã danh mục";
            dgvMonan.Columns["gia"].HeaderText = "Bảng giá";
            dgvMonan.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        void loadbangmonan()
        {
            loadmonan();
            addbindingmonan();
            loadcot();
        }
        bool checkdulieu()
        {
            int a, b, c;
            Int32.TryParse(txtMamon.Text, out a);
            Int32.TryParse(txtMadm.Text, out b);
            Int32.TryParse((txtGia.Text.Replace(".","")).Split(' ')[0], out c);
            if (a == 0 || b == 0 || c == 0) return false;
            return true;
        }
        private void btnThemmon_Click(object sender, EventArgs e)
        {
            if (checknhapthongtin())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkdulieu())
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkMadm_Danhmuc())
            {
                MessageBox.Show("Mã danh mục không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkMamon_Monan()||checkMamon_Monan())
            {
                MessageBox.Show("Món ăn đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc muốn THÊM món mới!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    ThucanBUS.Instance.Themthucan(Convert.ToInt32(txtMamon.Text), txtTenmon.Text, Convert.ToInt32(txtMadm.Text), Convert.ToInt32((txtGia.Text.Replace(".", "")).Split(' ')[0]));
                    loadmonan();
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
            if (!checkdulieu())
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkMadm_Danhmuc())
            {
                MessageBox.Show("Mã danh mục không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkMamon_Monan())
            {
                MessageBox.Show("Không tìm Mã món món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checktenmon_Tenmon())
            {
                MessageBox.Show("không tìm thấy món này ăn đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn CẬP NHẬT món ăn này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    ThucanBUS.Instance.Capnhatthucan(Convert.ToInt32(txtMamon.Text), txtTenmon.Text, Convert.ToInt32(txtMadm.Text), Convert.ToInt32((txtGia.Text.Replace(".", "")).Split(' ')[0]));
                    loadmonan();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMamon.Text=="")
            {
                MessageBox.Show("Chưa chọn món cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkMamon_Monan())
            {
                MessageBox.Show("Không tìm Mã món món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn XÓA món ăn này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    ThucanBUS.Instance.XoaThucan(Convert.ToInt32(txtMamon.Text));
                    loadmonan();
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                MessageBox.Show("Nhập tên món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                monanlist.DataSource = ThucanBUS.Instance.TimThucan(txtTim.Text);
                dgvMonan.DataSource = monanlist;
            }
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            loadmonan();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportMonan rpt = new ReportMonan();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
    }
}