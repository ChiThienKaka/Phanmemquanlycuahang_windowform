
namespace GUI
{
    partial class fQLMonan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLMonan));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvMonan = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.txtMadm = new DevExpress.XtraEditors.TextEdit();
            this.txtTenmon = new DevExpress.XtraEditors.TextEdit();
            this.txtMamon = new DevExpress.XtraEditors.TextEdit();
            this.txtTim = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnTailai = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapnhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemmon = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMadm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenmon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMamon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvMonan);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1118, 1048);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách món ăn";
            // 
            // dgvMonan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvMonan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonan.EnableHeadersVisualStyles = false;
            this.dgvMonan.Location = new System.Drawing.Point(2, 28);
            this.dgvMonan.MultiSelect = false;
            this.dgvMonan.Name = "dgvMonan";
            this.dgvMonan.ReadOnly = true;
            this.dgvMonan.RowHeadersVisible = false;
            this.dgvMonan.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen;
            this.dgvMonan.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMonan.RowTemplate.Height = 24;
            this.dgvMonan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonan.Size = new System.Drawing.Size(788, 1018);
            this.dgvMonan.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnTim);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtGia);
            this.groupControl2.Controls.Add(this.txtMadm);
            this.groupControl2.Controls.Add(this.txtTenmon);
            this.groupControl2.Controls.Add(this.txtMamon);
            this.groupControl2.Controls.Add(this.txtTim);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(790, 28);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(326, 1018);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Quản lý món ăn";
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.Image")));
            this.btnTim.Location = new System.Drawing.Point(258, 47);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(61, 40);
            this.btnTim.TabIndex = 10;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.labelControl4.Location = new System.Drawing.Point(5, 262);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(315, 24);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Giá:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.labelControl3.Location = new System.Drawing.Point(5, 212);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(315, 24);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Mã danh mục:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.labelControl2.Location = new System.Drawing.Point(5, 162);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(315, 24);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tên món:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.labelControl1.Location = new System.Drawing.Point(5, 104);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(315, 24);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Mã món ăn:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(5, 284);
            this.txtGia.Name = "txtGia";
            this.txtGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Properties.Appearance.Options.UseFont = true;
            this.txtGia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtGia.Size = new System.Drawing.Size(315, 26);
            this.txtGia.TabIndex = 5;
            // 
            // txtMadm
            // 
            this.txtMadm.Location = new System.Drawing.Point(5, 234);
            this.txtMadm.Name = "txtMadm";
            this.txtMadm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadm.Properties.Appearance.Options.UseFont = true;
            this.txtMadm.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtMadm.Size = new System.Drawing.Size(315, 26);
            this.txtMadm.TabIndex = 4;
            // 
            // txtTenmon
            // 
            this.txtTenmon.Location = new System.Drawing.Point(5, 184);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenmon.Properties.Appearance.Options.UseFont = true;
            this.txtTenmon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtTenmon.Size = new System.Drawing.Size(315, 26);
            this.txtTenmon.TabIndex = 3;
            // 
            // txtMamon
            // 
            this.txtMamon.Location = new System.Drawing.Point(5, 134);
            this.txtMamon.Name = "txtMamon";
            this.txtMamon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMamon.Properties.Appearance.Options.UseFont = true;
            this.txtMamon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtMamon.Size = new System.Drawing.Size(315, 26);
            this.txtMamon.TabIndex = 2;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(8, 54);
            this.txtTim.Name = "txtTim";
            this.txtTim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Properties.Appearance.Options.UseFont = true;
            this.txtTim.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtTim.Size = new System.Drawing.Size(246, 26);
            this.txtTim.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnReport);
            this.groupControl3.Controls.Add(this.btnTailai);
            this.groupControl3.Controls.Add(this.btnXoa);
            this.groupControl3.Controls.Add(this.btnCapnhat);
            this.groupControl3.Controls.Add(this.btnThemmon);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 585);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(322, 431);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Chức năng";
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.Image")));
            this.btnReport.Location = new System.Drawing.Point(2, 166);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(318, 40);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnTailai
            // 
            this.btnTailai.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTailai.Appearance.Options.UseFont = true;
            this.btnTailai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTailai.ImageOptions.Image")));
            this.btnTailai.Location = new System.Drawing.Point(112, 212);
            this.btnTailai.Name = "btnTailai";
            this.btnTailai.Size = new System.Drawing.Size(98, 42);
            this.btnTailai.TabIndex = 3;
            this.btnTailai.Text = "Tải lại";
            this.btnTailai.Click += new System.EventHandler(this.btnTailai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(2, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(318, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa món";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Appearance.Options.UseFont = true;
            this.btnCapnhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhat.ImageOptions.Image")));
            this.btnCapnhat.Location = new System.Drawing.Point(2, 74);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(318, 40);
            this.btnCapnhat.TabIndex = 1;
            this.btnCapnhat.Text = "Cập nhật món";
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThemmon
            // 
            this.btnThemmon.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmon.Appearance.Options.UseFont = true;
            this.btnThemmon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemmon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmon.ImageOptions.Image")));
            this.btnThemmon.Location = new System.Drawing.Point(2, 28);
            this.btnThemmon.Name = "btnThemmon";
            this.btnThemmon.Size = new System.Drawing.Size(318, 40);
            this.btnThemmon.TabIndex = 0;
            this.btnThemmon.Text = "Thêm món";
            this.btnThemmon.Click += new System.EventHandler(this.btnThemmon_Click);
            // 
            // fQLMonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 1048);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("fQLMonan.IconOptions.Image")));
            this.Name = "fQLMonan";
            this.Text = "Quản lý món ăn";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMadm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenmon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMamon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private DevExpress.XtraEditors.TextEdit txtMadm;
        private DevExpress.XtraEditors.TextEdit txtTenmon;
        private DevExpress.XtraEditors.TextEdit txtMamon;
        private DevExpress.XtraEditors.TextEdit txtTim;
        private DevExpress.XtraEditors.SimpleButton btnTailai;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnCapnhat;
        private DevExpress.XtraEditors.SimpleButton btnThemmon;
        private System.Windows.Forms.DataGridView dgvMonan;
        private DevExpress.XtraEditors.SimpleButton btnReport;
    }
}