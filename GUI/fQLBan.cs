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
    public partial class fQLBan : DevExpress.XtraEditors.XtraForm
    {
        public fQLBan()
        {
            InitializeComponent();
            loadbangban();
        }
        BindingSource QLbanlist = new BindingSource();
        void loadQLban()
        {
            QLbanlist.DataSource = BanBUS.Instance.GetQLBan();
            dgvQLBan.DataSource = QLbanlist;
        }
        void AddbindingQLban()
        {
            txtMaban.DataBindings.Add("Text", dgvQLBan.DataSource, "id", true, DataSourceUpdateMode.Never);
            txtTenban.DataBindings.Add("Text", dgvQLBan.DataSource, "tenban", true, DataSourceUpdateMode.Never);
            txtTrangthai.DataBindings.Add("Text", dgvQLBan.DataSource, "trangthai", true, DataSourceUpdateMode.Never);
        }
        void loadcot()
        {
            dgvQLBan.Columns["id"].HeaderText = "Mã bàn";
            dgvQLBan.Columns["tenban"].HeaderText = "Tên bàn";
            dgvQLBan.Columns["trangthai"].HeaderText = "Trạng thái";
            dgvQLBan.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.8F, System.Drawing.FontStyle.Bold);
        }
        void loadbangban()
        {
            loadQLban();
            AddbindingQLban();
            loadcot();
        }
        bool checkNhapthongtin()
        {
            if (txtMaban.Text == "" || txtTenban.Text == "" || txtTrangthai.Text == "") return true;
            return false;
        }
        int tenban(string s)
        {
            string so = "";
            int a;
            for (int i = 0; i <s.Length ; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    so += s[i];
                }
            }
            Int32.TryParse(so, out a);
            return a;
        }
        bool checkmaban_ban()
        {
            foreach (QLBanDTO item in BanBUS.Instance.GetQLBan())
            {
                if (item.Id == Convert.ToInt32(txtMaban.Text)) return true;
            }
            return false;
        }
        bool checktenban()
        {
            foreach (QLBanDTO item in BanBUS.Instance.GetQLBan())
            {
                if(tenban(item.Tenban)==tenban(txtTenban.Text)&& tenban(txtTenban.Text) != 0)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnThemban_Click(object sender, EventArgs e)
        {
            if (checkNhapthongtin())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tenban(txtTenban.Text) == 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checktenban())
            {
                MessageBox.Show("Tên bàn đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkmaban_ban())
            {
                MessageBox.Show("Mã bàn đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc muốn THÊM bàn mới!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    int trangthai=(txtTrangthai.Text == "đang trống") ? 0 : 1;
                    BanBUS.Instance.themban(Convert.ToInt32(txtMaban.Text),tenban(txtTenban.Text),trangthai);
                    loadQLban();
                }
            }
        }

        private void btnCapnhatban_Click(object sender, EventArgs e)
        {
            if (checkNhapthongtin())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tenban(txtTenban.Text) == 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkmaban_ban())
            {
                MessageBox.Show("Mã bàn Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn CẬP NHẬT bàn này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    int trangthai = (txtTrangthai.Text == "đang trống") ? 0 : 1;
                    BanBUS.Instance.capnhatban(Convert.ToInt32(txtMaban.Text), tenban(txtTenban.Text), trangthai);
                    loadQLban();
                }
            }
        }

        private void btnXoaban_Click(object sender, EventArgs e)
        {
            if (txtMaban.Text == "" || txtTrangthai.Text == "")
            {
                MessageBox.Show("Chưa nhập bàn cần XÓA (Lưu ý trạng thái)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtTrangthai.Text=="có người")
            {
                MessageBox.Show("Bạn Đang có người không thể XÓA!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkmaban_ban())
            {
                MessageBox.Show("Không tìm thấy Mã bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn XÓA bàn này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    int trangthai = (txtTrangthai.Text == "đang trống") ? 0 : 1;
                    BanBUS.Instance.Xoaban(Convert.ToInt32(txtMaban.Text),trangthai);
                    loadQLban();
                }
            }
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            loadQLban();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int a;Int32.TryParse(txtTim.Text, out a);
            if (a == 0)
            {
                MessageBox.Show("Tên bàn là 1 số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            QLbanlist.DataSource = BanBUS.Instance.timban(a);
            dgvQLBan.DataSource = QLbanlist;
        }

        private void rptReport_Click(object sender, EventArgs e)
        {
            ReportBan rpt = new ReportBan();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
    }
}