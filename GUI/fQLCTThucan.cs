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
    public partial class fQLCTThucan : DevExpress.XtraEditors.XtraForm
    {
        public fQLCTThucan()
        {
            InitializeComponent();
            loadbangCTmonan();
        }
        BindingSource CTmonanlist = new BindingSource();
        void loadCTmonan()
        {
            CTmonanlist.DataSource = GetCTmonanBUS.Instance.CTmonan();
            dgvCTMA.DataSource = CTmonanlist;
        }
        void addbindingCTmonan()
        {
            txtMmon.DataBindings.Add("Text", dgvCTMA.DataSource, "idthucan", true, DataSourceUpdateMode.Never);
            txtNguyenlieu.DataBindings.Add("Text", dgvCTMA.DataSource, "nguyenlieu", true, DataSourceUpdateMode.Never);
            txtCongthuc.DataBindings.Add("Text", dgvCTMA.DataSource, "congthuc", true, DataSourceUpdateMode.Never);
        }
        void loadcot()
        {
            dgvCTMA.Columns["idthucan"].HeaderText = "Mã thức ăn";
            dgvCTMA.Columns["nguyenlieu"].HeaderText = "Nguyên liệu";
            dgvCTMA.Columns["congthuc"].HeaderText = "Công thức";
            dgvCTMA.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.8F, System.Drawing.FontStyle.Bold);
        }
        void loadbangCTmonan()
        {
            loadCTmonan();
            addbindingCTmonan();
            loadcot();
        }
        bool checknhapthongtin()
        {
            if (txtMmon.Text == "" || txtNguyenlieu.Text == "" || txtCongthuc.Text=="") return true;
            return false;
        }
        bool checkMamon_Thucan()
        {
            foreach ( QLThucanDTO item in ThucanBUS.Instance.QLThucan())
            {
                if (item.Id == Convert.ToInt32(txtMmon.Text)) return true;
            }
            return false;
        }
        bool checkdulieu()
        {
            int a;Int32.TryParse(txtMmon.Text, out a);
            if (a == 0) return true;
            return false;
        }
        bool checkMaMon_CTMon()
        {
            foreach (QLCTmonanDTO item in GetCTmonanBUS.Instance.CTmonan())
            {
                if (item.Idthucan == Convert.ToInt32(txtMmon.Text)) return true;
            }
            return false;
        }
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (checknhapthongtin())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkdulieu())
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkMaMon_CTMon())
            {
                MessageBox.Show("Mã món này đãt tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkMamon_Thucan())
            {
                MessageBox.Show("Mã món không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc muốn THÊM Chi Tiết món mới!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    GetCTmonanBUS.Instance.ThemCTmon(Convert.ToInt32(txtMmon.Text), txtNguyenlieu.Text, txtCongthuc.Text);
                    loadCTmonan();
                }
            }
        }

        private void btnCapnhatCT_Click(object sender, EventArgs e)
        {
            if (checknhapthongtin())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkdulieu())
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkMaMon_CTMon())
            {
                MessageBox.Show("Mã món này không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn CẬP NHẬT Chi Tiết món này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    GetCTmonanBUS.Instance.CapnhatCTmon(Convert.ToInt32(txtMmon.Text), txtNguyenlieu.Text, txtCongthuc.Text);
                    loadCTmonan();
                }
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (txtMmon.Text=="")
            {
                MessageBox.Show("Chưa chọn CT món cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkdulieu())
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkMaMon_CTMon())
            {
                MessageBox.Show("Mã món này không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn XÓA Chi Tiết món này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    GetCTmonanBUS.Instance.XoaCTmon(Convert.ToInt32(txtMmon.Text));
                    loadCTmonan();
                }
            }
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            loadCTmonan();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            CTmonanlist.DataSource = GetCTmonanBUS.Instance.TimCTmonan(txtTim.Text);
            dgvCTMA.DataSource = CTmonanlist;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportCTthucan rpt = new ReportCTthucan();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
    }
}