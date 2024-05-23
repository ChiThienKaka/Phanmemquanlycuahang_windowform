
namespace GUI
{
    partial class fTrangchu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTrangchu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDatBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnphanquyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhancong = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongtin = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.lbGio = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbNgay = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangNhap,
            this.btnDatBan,
            this.btnphanquyen,
            this.btnDangXuat,
            this.btnPhancong,
            this.btnThongtin});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1798, 193);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.LargeWidth = 80;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDatBan
            // 
            this.btnDatBan.Caption = "Đặt bàn";
            this.btnDatBan.Enabled = false;
            this.btnDatBan.Id = 2;
            this.btnDatBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDatBan.ImageOptions.Image")));
            this.btnDatBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDatBan.ImageOptions.LargeImage")));
            this.btnDatBan.LargeWidth = 80;
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDatBan_ItemClick);
            // 
            // btnphanquyen
            // 
            this.btnphanquyen.Caption = "Quản lý";
            this.btnphanquyen.Enabled = false;
            this.btnphanquyen.Id = 3;
            this.btnphanquyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnphanquyen.ImageOptions.Image")));
            this.btnphanquyen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnphanquyen.ImageOptions.LargeImage")));
            this.btnphanquyen.LargeWidth = 80;
            this.btnphanquyen.Name = "btnphanquyen";
            this.btnphanquyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnphanquyen_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 6;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.LargeWidth = 80;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnPhancong
            // 
            this.btnPhancong.Caption = "Bảng phân công";
            this.btnPhancong.Enabled = false;
            this.btnPhancong.Id = 7;
            this.btnPhancong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhancong.ImageOptions.Image")));
            this.btnPhancong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhancong.ImageOptions.LargeImage")));
            this.btnPhancong.LargeWidth = 80;
            this.btnPhancong.Name = "btnPhancong";
            this.btnPhancong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhancong_ItemClick);
            // 
            // btnThongtin
            // 
            this.btnThongtin.Caption = "Thông tin";
            this.btnThongtin.Enabled = false;
            this.btnThongtin.Id = 8;
            this.btnThongtin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongtin.ImageOptions.Image")));
            this.btnThongtin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongtin.ImageOptions.LargeImage")));
            this.btnThongtin.LargeWidth = 80;
            this.btnThongtin.Name = "btnThongtin";
            this.btnThongtin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongtin_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDatBan);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThongtin);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Chức năng";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnphanquyen);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPhancong);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Chức năng";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // lbGio
            // 
            this.lbGio.Appearance.BackColor = System.Drawing.Color.Silver;
            this.lbGio.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGio.Appearance.Options.UseBackColor = true;
            this.lbGio.Appearance.Options.UseFont = true;
            this.lbGio.Location = new System.Drawing.Point(1595, 145);
            this.lbGio.Name = "lbGio";
            this.lbGio.Size = new System.Drawing.Size(94, 28);
            this.lbGio.TabIndex = 2;
            this.lbGio.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbNgay
            // 
            this.lbNgay.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbNgay.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Appearance.Options.UseBackColor = true;
            this.lbNgay.Appearance.Options.UseFont = true;
            this.lbNgay.Location = new System.Drawing.Point(1515, 92);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(78, 28);
            this.lbNgay.TabIndex = 4;
            this.lbNgay.Text = "000000";
            // 
            // fTrangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 999);
            this.Controls.Add(this.lbNgay);
            this.Controls.Add(this.lbGio);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("fTrangchu.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fTrangchu";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDatBan;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnphanquyen;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnPhancong;
        private DevExpress.XtraEditors.LabelControl lbGio;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lbNgay;
        private DevExpress.XtraBars.BarButtonItem btnThongtin;
    }
}

