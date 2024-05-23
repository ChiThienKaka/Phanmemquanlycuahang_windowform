
namespace GUI
{
    partial class fPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPhanCong));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvPhancong = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnTailai = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapnhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhancong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvPhancong);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1118, 1048);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách phân công";
            // 
            // dgvPhancong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPhancong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhancong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhancong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhancong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhancong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhancong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhancong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhancong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhancong.EnableHeadersVisualStyles = false;
            this.dgvPhancong.Location = new System.Drawing.Point(2, 28);
            this.dgvPhancong.MultiSelect = false;
            this.dgvPhancong.Name = "dgvPhancong";
            this.dgvPhancong.ReadOnly = true;
            this.dgvPhancong.RowHeadersVisible = false;
            this.dgvPhancong.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen;
            this.dgvPhancong.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPhancong.RowTemplate.Height = 24;
            this.dgvPhancong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhancong.Size = new System.Drawing.Size(788, 1018);
            this.dgvPhancong.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.btnTim);
            this.groupControl2.Controls.Add(this.txtNV);
            this.groupControl2.Controls.Add(this.txtMaNV);
            this.groupControl2.Controls.Add(this.txtTim);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(790, 28);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(326, 1018);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Quản lý phân công";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnTailai);
            this.groupControl3.Controls.Add(this.btnXoa);
            this.groupControl3.Controls.Add(this.btnCapnhat);
            this.groupControl3.Controls.Add(this.btnThem);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 585);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(322, 431);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Chức năng";
            // 
            // btnTailai
            // 
            this.btnTailai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTailai.ImageOptions.Image")));
            this.btnTailai.Location = new System.Drawing.Point(112, 166);
            this.btnTailai.Name = "btnTailai";
            this.btnTailai.Size = new System.Drawing.Size(98, 42);
            this.btnTailai.TabIndex = 4;
            this.btnTailai.Text = "Tải lại";
            this.btnTailai.Click += new System.EventHandler(this.btnTailai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(2, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(318, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa nhiệm vụ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhat.ImageOptions.Image")));
            this.btnCapnhat.Location = new System.Drawing.Point(2, 74);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(318, 40);
            this.btnCapnhat.TabIndex = 1;
            this.btnCapnhat.Text = "Cập nhật nhiệm vụ";
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(2, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(318, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm  Nhiệm vụ ";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.labelControl2.Location = new System.Drawing.Point(5, 163);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(315, 24);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Nhiệm vụ:";
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
            this.labelControl1.Location = new System.Drawing.Point(5, 104);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(315, 24);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mã nhân viên:";
            // 
            // btnTim
            // 
            this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.Image")));
            this.btnTim.Location = new System.Drawing.Point(258, 47);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(61, 40);
            this.btnTim.TabIndex = 3;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtNV
            // 
            this.txtNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNV.Location = new System.Drawing.Point(5, 185);
            this.txtNV.Multiline = true;
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(315, 221);
            this.txtNV.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(5, 134);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(315, 26);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(6, 54);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(246, 26);
            this.txtTim.TabIndex = 0;
            // 
            // fPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 1048);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("fPhanCong.IconOptions.Image")));
            this.Name = "fPhanCong";
            this.Text = "Phân công";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhancong)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPhancong;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTim;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnTailai;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnCapnhat;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}