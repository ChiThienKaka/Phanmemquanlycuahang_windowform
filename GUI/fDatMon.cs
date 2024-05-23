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
    public partial class fDatMon : DevExpress.XtraEditors.XtraForm
    {
        bool makhtt = false;
        public fDatMon(BanDTO ban,List<GetDsthemonDTO> dsmdc)
        {
            InitializeComponent();
            lbTenban.Tag = ban;
            lbTenban.Text = "Bàn số "+ban.Tenban.ToString();
            lvDSmon.Tag = ban;
            GetMondachon(ban, dsmdc);
        }
        void GetMondachon(BanDTO ban,List<GetDsthemonDTO> dsmdc)
        {
            lvDSmon.Items.Clear();
            foreach (GetDsthemonDTO item in dsmdc)
            {
                if (item.Idban==ban.Id && item.Trangthai==0)
                {
                    ListViewItem lvi = new ListViewItem(GettenmonBUS.Instance.Gettenmon(item.Idthucan));
                    lvi.SubItems.Add(item.Soluong.ToString());
                    lvi.SubItems.Add(GetgiaBUS.Instance.Getdongia(item.Idthucan).ToString("c", culture).Split(',')[0] + " VNĐ");
                    lvDSmon.Items.Add(lvi);
                }
            }
        }
        CultureInfo culture = new CultureInfo("vi-Vn");
        private void btnTCX_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ThucanDTO thucan=new ThucanDTO();
            foreach (ThucanDTO item in ThucanBUS.Instance.Thucan())
            {
                if (Convert.ToInt32(btn.Tag) == item.Id)
                {
                    thucan = item;
                    break;
                }
            }
            fThemmonvachitietmon f = new fThemmonvachitietmon(thucan);
            f.Location = new Point(btn.Location.X+230,btn.Location.Y+130);
            f.ShowDialog();
            int dem = 0;
            if (f.Luachon == 1)
            {
                foreach (ListViewItem item in lvDSmon.Items)
                {
                    if (item.SubItems[0].Text == f.Tenmon)
                    {
                        item.SubItems[1].Text = (Convert.ToInt32(item.SubItems[1].Text)+f.Soluong).ToString();dem++;
                        break;
                    }
                }
                if (dem != 1)
                {
                    ListViewItem lvi = new ListViewItem(f.Tenmon);
                    lvi.SubItems.Add(f.Soluong.ToString());
                    lvi.SubItems.Add(f.Gia.ToString("c", culture).Split(',')[0] + " VNĐ");
                    lvDSmon.Items.Add(lvi);
                    dem = 0;
                }
            }
        }

        int i = 0;
        void xoaTongtien()
        {
            foreach (ListViewItem item in lvDSmon.Items)
            {
                if (item.SubItems[0].Text == "")
                {
                    item.Remove();
                }
                if(item.SubItems[0].Text=="Giảm giá:")
                {
                    item.Remove();
                }
                if (item.SubItems[0].Text == "Tổng tiền:")
                {
                    item.Remove();
                    break;
                }
            }
        }
        private void btnTongtien_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                foreach (ListViewItem item in lvDSmon.Items)
                {
                    if (item.SubItems[0].Text == "")
                    {
                        item.Remove();
                    }
                    if (item.SubItems[0].Text== "Giảm giá:")
                    {
                        item.Remove();
                    }
                    if (item.SubItems[0].Text == "Tổng tiền:")
                    {
                        item.Remove();
                        break;
                    }
                }
                i = 0;
            }
            int dongia = 0, soluong = 0, giamgia = (int)speGiamgia.Value;
            if (makhtt) giamgia += 10;
            float tongtien = 0;
            foreach (ListViewItem item in lvDSmon.Items)
            {
                dongia = Convert.ToInt32(((item.SubItems[2].Text).Replace(".", "")).Split(' ')[0]);
                soluong = Convert.ToInt32(item.SubItems[1].Text);
                tongtien = (soluong * dongia) + tongtien;
            }
            tongtien = (float)((float)(100 - giamgia) / 100.0)*tongtien;
            ListViewItem lvi0 = new ListViewItem("");
            lvDSmon.Items.Add(lvi0);
            ListViewItem lvi3 = new ListViewItem("Giảm giá:");
            lvi3.SubItems.Add("");
            lvi3.SubItems.Add(giamgia.ToString() + "%");
            lvDSmon.Items.Add(lvi3);
            ListViewItem lvi1 = new ListViewItem("Tổng tiền:");
            lvi1.SubItems.Add("");
            lvi1.SubItems.Add(tongtien.ToString("c", culture).Split(',')[0] + " VNĐ");
            lvi1.ForeColor = System.Drawing.Color.Red;
            lvDSmon.Items.Add(lvi1);
            i++;
        }
        private void btnGoimon_Click(object sender, EventArgs e)
        {
            //Xem bàn đó có món chưa
            List<GetDsthemonDTO> dsmdc = GetmondachonBUS.Instance.Getdsthemmon();
            int i = 0;
            foreach (GetDsthemonDTO item in dsmdc)
            {
                if(item.Idban==(lbTenban.Tag as BanDTO).Id&&item.Trangthai == 0)
                {
                    i = item.Idthucan;
                    break;
                }
            }
            if (lvDSmon.Items.Count == 0)
            {
                MessageBox.Show("Chưa chọn món!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (i>0)
            {
                MessageBox.Show("Chưa thanh toán hóa đơn!","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn thêm tất cả những món trên!","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                xoaTongtien();
                int idban = (lbTenban.Tag as BanDTO).Id;
                int idthucan = 0, soluong = 0; float tongtien = 0,sum=0; 
                int giamgia = (int)speGiamgia.Value;
                if (makhtt) { giamgia += 10; }
                foreach (ListViewItem item in lvDSmon.Items)
                {
                    idthucan = (int)GetIdmonanBUS.Instance.GetIdmonan(item.SubItems[0].Text);
                    soluong = Convert.ToInt32(item.SubItems[1].Text);
                    tongtien = soluong * Convert.ToInt32(((item.SubItems[2].Text).Replace(".", "")).Split(' ')[0]);
                    sum = tongtien - ((float)((float)giamgia/100.0)* tongtien);
                    InHoaDonBUS.Instance.Inhoadon(idban);
                    InCThoadonBUS.Instance.InCThoadon(idthucan, soluong, sum,giamgia);
                    UpdateBananThemmonBUS.Instance.UpdateBanthemmon(idban);
                }
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thanh toán hóa đơn không!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                lvDSmon.Items.Clear();
                int idban = (lbTenban.Tag as BanDTO).Id;
                UpdatetrangthaiHdBUS.Instance.UpdatetrangthaiHD(idban);
                UpdateTrangthaibanThanhtoanBUS.Instance.Updatetrangthaibanthanhtoan(idban);
                makhtt = false;
            }
        }

        private void btnXTC_Click(object sender, EventArgs e)
        {
            lvDSmon.Items.Clear();
        }

        private void btnXoamon_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvDSmon.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Chưa chọn mọn cần XÓA!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                lvDSmon.Items[lvDSmon.FocusedItem.Index].Remove();
            }
            catch{
                
            } 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (DataRow item in KhachHangTTBUS.Instance.BangKhangHangTT().Rows)
            {
                if (txtMKHTT.Text == item["MaKH"].ToString())
                {
                    MessageBox.Show("Xác nhận thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makhtt = true;
                    return;
                }
            }
        }
    }
}