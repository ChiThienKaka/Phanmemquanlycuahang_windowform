
namespace GUI
{
    partial class fThongkeKT
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongkeKT));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBDC = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateNgayvao = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateNgayra = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnBDT = new DevExpress.XtraEditors.SimpleButton();
            this.btnBDD = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayvao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayvao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(2, 28);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Tổng tiền";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1505, 655);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "bdDTbh";
            title1.Text = "Biểu đồ doanh thu bán hàng theo ngày";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chart1.Titles.Add(title1);
            // 
            // btnBDC
            // 
            this.btnBDC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBDC.ImageOptions.Image")));
            this.btnBDC.Location = new System.Drawing.Point(503, 46);
            this.btnBDC.Name = "btnBDC";
            this.btnBDC.Size = new System.Drawing.Size(191, 59);
            this.btnBDC.TabIndex = 1;
            this.btnBDC.Text = "Biểu đồ cột";
            this.btnBDC.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ngày vào:";
            // 
            // dateNgayvao
            // 
            this.dateNgayvao.EditValue = new System.DateTime(2022, 7, 6, 8, 46, 54, 536);
            this.dateNgayvao.Location = new System.Drawing.Point(101, 57);
            this.dateNgayvao.Name = "dateNgayvao";
            this.dateNgayvao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayvao.Properties.Appearance.Options.UseFont = true;
            this.dateNgayvao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayvao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayvao.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateNgayvao.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateNgayvao.Size = new System.Drawing.Size(148, 28);
            this.dateNgayvao.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(280, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày ra:";
            // 
            // dateNgayra
            // 
            this.dateNgayra.EditValue = new System.DateTime(2022, 7, 6, 13, 16, 2, 785);
            this.dateNgayra.Location = new System.Drawing.Point(349, 57);
            this.dateNgayra.Name = "dateNgayra";
            this.dateNgayra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayra.Properties.Appearance.Options.UseFont = true;
            this.dateNgayra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayra.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateNgayra.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateNgayra.Size = new System.Drawing.Size(148, 28);
            this.dateNgayra.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.dateNgayvao);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dateNgayra);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1509, 123);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Nhập ngày";
            // 
            // btnBDT
            // 
            this.btnBDT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBDT.ImageOptions.Image")));
            this.btnBDT.Location = new System.Drawing.Point(897, 46);
            this.btnBDT.Name = "btnBDT";
            this.btnBDT.Size = new System.Drawing.Size(191, 59);
            this.btnBDT.TabIndex = 6;
            this.btnBDT.Text = "Biểu đồ tròn";
            this.btnBDT.Click += new System.EventHandler(this.btnBDT_Click);
            // 
            // btnBDD
            // 
            this.btnBDD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBDD.ImageOptions.Image")));
            this.btnBDD.Location = new System.Drawing.Point(700, 46);
            this.btnBDD.Name = "btnBDD";
            this.btnBDD.Size = new System.Drawing.Size(191, 59);
            this.btnBDD.TabIndex = 5;
            this.btnBDD.Text = "Biểu đồ đường";
            this.btnBDD.Click += new System.EventHandler(this.btnThongke1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.chart1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 123);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1509, 847);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Biểu đồ";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnBDT);
            this.groupControl3.Controls.Add(this.btnBDD);
            this.groupControl3.Controls.Add(this.btnBDC);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 683);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1505, 162);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Chức năng";
            // 
            // fThongkeKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 970);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("fThongkeKT.IconOptions.Image")));
            this.Name = "fThongkeKT";
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayvao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayvao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DevExpress.XtraEditors.SimpleButton btnBDC;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateNgayvao;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateNgayra;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnBDD;
        private DevExpress.XtraEditors.SimpleButton btnBDT;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}