using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class fTrangchu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public fTrangchu()
        {
            InitializeComponent();
            loadngay();
            skins();
        }
        public static bool checkdangnhap = false;
        public static bool loaitk = false;
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "McSkin";//tên giao diện
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
        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fDangnhap f = new fDangnhap();
            f.ShowDialog();
            if (checkdangnhap==true)
            {
                btnDangNhap.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnDatBan.Enabled = true;
                btnPhancong.Enabled = true;
                btnThongtin.Enabled = true;
            }
            if (loaitk==true)
            {
                btnphanquyen.Enabled = true;
            }
        }
        private void btnDatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(fBan));
        }
        private void btnphanquyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fPhanquyen f = new fPhanquyen();
            f.ShowDialog();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnDangNhap.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btnphanquyen.Enabled = false;
            btnDatBan.Enabled = false;
            loaitk = false;
            checkdangnhap = false;
            btnPhancong.Enabled = false;
            btnThongtin.Enabled = false;
        }

        private void btnPhancong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportPhanCong rpt = new ReportPhanCong();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
        void loadngay()
        {
            DateTime date = DateTime.Now;
            lbNgay.Text = "Ngày " + date.Day.ToString() + " tháng " + date.Month.ToString() + " năm " + date.Year.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnThongtin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fThongtinhcanhan f = new fThongtinhcanhan(fDangnhap.taikhoan);
            f.ShowDialog();
        }
    }
}