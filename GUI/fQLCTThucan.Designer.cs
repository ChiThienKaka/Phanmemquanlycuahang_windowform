
namespace GUI
{
    partial class fQLCTThucan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLCTThucan));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvCTMA = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtCongthuc = new System.Windows.Forms.TextBox();
            this.txtNguyenlieu = new System.Windows.Forms.TextBox();
            this.txtMmon = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnTailai = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaCT = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapnhatCT = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemCT = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvCTMA);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1118, 1048);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách chi tiết món ăn";
            // 
            // dgvCTMA
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCTMA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTMA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTMA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTMA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTMA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTMA.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCTMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTMA.EnableHeadersVisualStyles = false;
            this.dgvCTMA.Location = new System.Drawing.Point(2, 28);
            this.dgvCTMA.MultiSelect = false;
            this.dgvCTMA.Name = "dgvCTMA";
            this.dgvCTMA.ReadOnly = true;
            this.dgvCTMA.RowHeadersVisible = false;
            this.dgvCTMA.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen;
            this.dgvCTMA.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCTMA.RowTemplate.Height = 24;
            this.dgvCTMA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTMA.Size = new System.Drawing.Size(788, 1018);
            this.dgvCTMA.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtCongthuc);
            this.groupControl2.Controls.Add(this.txtNguyenlieu);
            this.groupControl2.Controls.Add(this.txtMmon);
            this.groupControl2.Controls.Add(this.txtTim);
            this.groupControl2.Controls.Add(this.btnTim);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(790, 28);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(326, 1018);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Quản lý Chi tiết món ăn";
            // 
            // txtCongthuc
            // 
            this.txtCongthuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongthuc.Location = new System.Drawing.Point(5, 305);
            this.txtCongthuc.Multiline = true;
            this.txtCongthuc.Name = "txtCongthuc";
            this.txtCongthuc.Size = new System.Drawing.Size(315, 124);
            this.txtCongthuc.TabIndex = 14;
            // 
            // txtNguyenlieu
            // 
            this.txtNguyenlieu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguyenlieu.Location = new System.Drawing.Point(5, 196);
            this.txtNguyenlieu.Multiline = true;
            this.txtNguyenlieu.Name = "txtNguyenlieu";
            this.txtNguyenlieu.Size = new System.Drawing.Size(315, 73);
            this.txtNguyenlieu.TabIndex = 13;
            // 
            // txtMmon
            // 
            this.txtMmon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMmon.Location = new System.Drawing.Point(5, 134);
            this.txtMmon.Name = "txtMmon";
            this.txtMmon.Size = new System.Drawing.Size(315, 26);
            this.txtMmon.TabIndex = 12;
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(6, 54);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(246, 26);
            this.txtTim.TabIndex = 11;
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
            this.labelControl3.Location = new System.Drawing.Point(5, 275);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(315, 24);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Công thức:";
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
            this.labelControl2.Text = "Nguyên liệu:";
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
            this.labelControl1.Text = "Mã món ăn:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnReport);
            this.groupControl3.Controls.Add(this.btnTailai);
            this.groupControl3.Controls.Add(this.btnXoaCT);
            this.groupControl3.Controls.Add(this.btnCapnhatCT);
            this.groupControl3.Controls.Add(this.btnThemCT);
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
            // btnXoaCT
            // 
            this.btnXoaCT.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCT.Appearance.Options.UseFont = true;
            this.btnXoaCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCT.ImageOptions.Image")));
            this.btnXoaCT.Location = new System.Drawing.Point(2, 120);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(318, 40);
            this.btnXoaCT.TabIndex = 2;
            this.btnXoaCT.Text = "Xóa CT món ăn";
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnCapnhatCT
            // 
            this.btnCapnhatCT.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhatCT.Appearance.Options.UseFont = true;
            this.btnCapnhatCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhatCT.ImageOptions.Image")));
            this.btnCapnhatCT.Location = new System.Drawing.Point(2, 74);
            this.btnCapnhatCT.Name = "btnCapnhatCT";
            this.btnCapnhatCT.Size = new System.Drawing.Size(318, 40);
            this.btnCapnhatCT.TabIndex = 1;
            this.btnCapnhatCT.Text = "Cập nhật CT món ăn";
            this.btnCapnhatCT.Click += new System.EventHandler(this.btnCapnhatCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCT.Appearance.Options.UseFont = true;
            this.btnThemCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.ImageOptions.Image")));
            this.btnThemCT.Location = new System.Drawing.Point(2, 28);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(318, 40);
            this.btnThemCT.TabIndex = 0;
            this.btnThemCT.Text = "Thêm CT món ăn";
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // fQLCTThucan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 1048);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("fQLCTThucan.IconOptions.Image")));
            this.Name = "fQLCTThucan";
            this.Text = "Quản lý chi tiết món ăn";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
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
        private DevExpress.XtraEditors.SimpleButton btnTailai;
        private DevExpress.XtraEditors.SimpleButton btnXoaCT;
        private DevExpress.XtraEditors.SimpleButton btnCapnhatCT;
        private DevExpress.XtraEditors.SimpleButton btnThemCT;
        private System.Windows.Forms.DataGridView dgvCTMA;
        private System.Windows.Forms.TextBox txtCongthuc;
        private System.Windows.Forms.TextBox txtNguyenlieu;
        private System.Windows.Forms.TextBox txtMmon;
        private System.Windows.Forms.TextBox txtTim;
        private DevExpress.XtraEditors.SimpleButton btnReport;
    }
}