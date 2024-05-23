
namespace GUI
{
    partial class fQLBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLBan));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvQLBan = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTrangthai = new DevExpress.XtraEditors.TextEdit();
            this.txtTenban = new DevExpress.XtraEditors.TextEdit();
            this.txtMaban = new DevExpress.XtraEditors.TextEdit();
            this.txtTim = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.rptReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnTailai = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaban = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapnhatban = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemban = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangthai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvQLBan);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1118, 1048);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách bàn";
            // 
            // dgvQLBan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvQLBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLBan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLBan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQLBan.EnableHeadersVisualStyles = false;
            this.dgvQLBan.Location = new System.Drawing.Point(2, 28);
            this.dgvQLBan.MultiSelect = false;
            this.dgvQLBan.Name = "dgvQLBan";
            this.dgvQLBan.ReadOnly = true;
            this.dgvQLBan.RowHeadersVisible = false;
            this.dgvQLBan.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen;
            this.dgvQLBan.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLBan.RowTemplate.Height = 24;
            this.dgvQLBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLBan.Size = new System.Drawing.Size(788, 1018);
            this.dgvQLBan.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnTim);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtTrangthai);
            this.groupControl2.Controls.Add(this.txtTenban);
            this.groupControl2.Controls.Add(this.txtMaban);
            this.groupControl2.Controls.Add(this.txtTim);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(790, 28);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(326, 1018);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Quản lý bàn";
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.Image")));
            this.btnTim.Location = new System.Drawing.Point(258, 47);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(61, 40);
            this.btnTim.TabIndex = 8;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
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
            this.labelControl3.Location = new System.Drawing.Point(5, 228);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(315, 24);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Trạng thái:";
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
            this.labelControl2.Location = new System.Drawing.Point(5, 166);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(315, 24);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Số bàn:";
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
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Mã bàn:";
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(5, 258);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangthai.Properties.Appearance.Options.UseFont = true;
            this.txtTrangthai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtTrangthai.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtTrangthai.Size = new System.Drawing.Size(315, 26);
            this.txtTrangthai.TabIndex = 4;
            // 
            // txtTenban
            // 
            this.txtTenban.Location = new System.Drawing.Point(5, 196);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenban.Properties.Appearance.Options.UseFont = true;
            this.txtTenban.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtTenban.Size = new System.Drawing.Size(315, 26);
            this.txtTenban.TabIndex = 3;
            // 
            // txtMaban
            // 
            this.txtMaban.Location = new System.Drawing.Point(5, 134);
            this.txtMaban.Name = "txtMaban";
            this.txtMaban.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaban.Properties.Appearance.Options.UseFont = true;
            this.txtMaban.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtMaban.Size = new System.Drawing.Size(315, 26);
            this.txtMaban.TabIndex = 2;
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
            this.groupControl3.Controls.Add(this.rptReport);
            this.groupControl3.Controls.Add(this.btnTailai);
            this.groupControl3.Controls.Add(this.btnXoaban);
            this.groupControl3.Controls.Add(this.btnCapnhatban);
            this.groupControl3.Controls.Add(this.btnThemban);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 585);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(322, 431);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Chức năng";
            // 
            // rptReport
            // 
            this.rptReport.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptReport.Appearance.Options.UseFont = true;
            this.rptReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rptReport.ImageOptions.Image")));
            this.rptReport.Location = new System.Drawing.Point(2, 166);
            this.rptReport.Name = "rptReport";
            this.rptReport.Size = new System.Drawing.Size(318, 40);
            this.rptReport.TabIndex = 4;
            this.rptReport.Text = "Report";
            this.rptReport.Click += new System.EventHandler(this.rptReport_Click);
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
            // btnXoaban
            // 
            this.btnXoaban.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaban.Appearance.Options.UseFont = true;
            this.btnXoaban.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaban.ImageOptions.Image")));
            this.btnXoaban.Location = new System.Drawing.Point(2, 120);
            this.btnXoaban.Name = "btnXoaban";
            this.btnXoaban.Size = new System.Drawing.Size(318, 40);
            this.btnXoaban.TabIndex = 2;
            this.btnXoaban.Text = "Xóa bàn";
            this.btnXoaban.Click += new System.EventHandler(this.btnXoaban_Click);
            // 
            // btnCapnhatban
            // 
            this.btnCapnhatban.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhatban.Appearance.Options.UseFont = true;
            this.btnCapnhatban.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhatban.ImageOptions.Image")));
            this.btnCapnhatban.Location = new System.Drawing.Point(2, 74);
            this.btnCapnhatban.Name = "btnCapnhatban";
            this.btnCapnhatban.Size = new System.Drawing.Size(318, 40);
            this.btnCapnhatban.TabIndex = 1;
            this.btnCapnhatban.Text = "Cập nhật bàn";
            this.btnCapnhatban.Click += new System.EventHandler(this.btnCapnhatban_Click);
            // 
            // btnThemban
            // 
            this.btnThemban.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemban.Appearance.Options.UseFont = true;
            this.btnThemban.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemban.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemban.ImageOptions.Image")));
            this.btnThemban.Location = new System.Drawing.Point(2, 28);
            this.btnThemban.Name = "btnThemban";
            this.btnThemban.Size = new System.Drawing.Size(318, 40);
            this.btnThemban.TabIndex = 0;
            this.btnThemban.Text = "Thêm bàn";
            this.btnThemban.Click += new System.EventHandler(this.btnThemban_Click);
            // 
            // fQLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 1048);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("fQLBan.IconOptions.Image")));
            this.Name = "fQLBan";
            this.Text = "Quản lý bàn";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangthai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaban.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTrangthai;
        private DevExpress.XtraEditors.TextEdit txtTenban;
        private DevExpress.XtraEditors.TextEdit txtMaban;
        private DevExpress.XtraEditors.TextEdit txtTim;
        private DevExpress.XtraEditors.SimpleButton btnTailai;
        private DevExpress.XtraEditors.SimpleButton btnXoaban;
        private DevExpress.XtraEditors.SimpleButton btnCapnhatban;
        private DevExpress.XtraEditors.SimpleButton btnThemban;
        private System.Windows.Forms.DataGridView dgvQLBan;
        private DevExpress.XtraEditors.SimpleButton rptReport;
    }
}