
namespace GUI
{
    partial class fChitietmonan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChitietmonan));
            this.lbtenmon = new DevExpress.XtraEditors.LabelControl();
            this.lbNguyenlieu = new DevExpress.XtraEditors.LabelControl();
            this.lbCachlam = new DevExpress.XtraEditors.LabelControl();
            this.lbDongia = new DevExpress.XtraEditors.LabelControl();
            this.txtTenmon = new System.Windows.Forms.TextBox();
            this.txtNguyenlieu = new System.Windows.Forms.TextBox();
            this.txtCachlam = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbTTMA = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lbtenmon
            // 
            this.lbtenmon.Location = new System.Drawing.Point(12, 45);
            this.lbtenmon.Name = "lbtenmon";
            this.lbtenmon.Size = new System.Drawing.Size(56, 16);
            this.lbtenmon.TabIndex = 0;
            this.lbtenmon.Text = "Tên món:";
            // 
            // lbNguyenlieu
            // 
            this.lbNguyenlieu.Location = new System.Drawing.Point(12, 85);
            this.lbNguyenlieu.Name = "lbNguyenlieu";
            this.lbNguyenlieu.Size = new System.Drawing.Size(76, 17);
            this.lbNguyenlieu.TabIndex = 1;
            this.lbNguyenlieu.Text = "Nguyên liệu:";
            // 
            // lbCachlam
            // 
            this.lbCachlam.Location = new System.Drawing.Point(12, 215);
            this.lbCachlam.Name = "lbCachlam";
            this.lbCachlam.Size = new System.Drawing.Size(58, 16);
            this.lbCachlam.TabIndex = 2;
            this.lbCachlam.Text = "Cách làm:";
            // 
            // lbDongia
            // 
            this.lbDongia.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDongia.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbDongia.Appearance.Options.UseFont = true;
            this.lbDongia.Appearance.Options.UseForeColor = true;
            this.lbDongia.Location = new System.Drawing.Point(147, 381);
            this.lbDongia.Name = "lbDongia";
            this.lbDongia.Size = new System.Drawing.Size(53, 21);
            this.lbDongia.TabIndex = 3;
            this.lbDongia.Text = "0 VNĐ";
            // 
            // txtTenmon
            // 
            this.txtTenmon.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTenmon.Enabled = false;
            this.txtTenmon.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenmon.Location = new System.Drawing.Point(98, 45);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.ReadOnly = true;
            this.txtTenmon.Size = new System.Drawing.Size(232, 23);
            this.txtTenmon.TabIndex = 4;
            // 
            // txtNguyenlieu
            // 
            this.txtNguyenlieu.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNguyenlieu.Enabled = false;
            this.txtNguyenlieu.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguyenlieu.Location = new System.Drawing.Point(98, 85);
            this.txtNguyenlieu.Multiline = true;
            this.txtNguyenlieu.Name = "txtNguyenlieu";
            this.txtNguyenlieu.ReadOnly = true;
            this.txtNguyenlieu.Size = new System.Drawing.Size(232, 113);
            this.txtNguyenlieu.TabIndex = 5;
            // 
            // txtCachlam
            // 
            this.txtCachlam.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCachlam.Enabled = false;
            this.txtCachlam.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCachlam.Location = new System.Drawing.Point(98, 215);
            this.txtCachlam.Multiline = true;
            this.txtCachlam.Name = "txtCachlam";
            this.txtCachlam.ReadOnly = true;
            this.txtCachlam.Size = new System.Drawing.Size(232, 160);
            this.txtCachlam.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnThoat.FlatAppearance.BorderSize = 2;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThoat.Location = new System.Drawing.Point(256, 413);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(74, 38);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbTTMA
            // 
            this.lbTTMA.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTMA.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbTTMA.Appearance.Options.UseFont = true;
            this.lbTTMA.Appearance.Options.UseForeColor = true;
            this.lbTTMA.Location = new System.Drawing.Point(98, 18);
            this.lbTTMA.Name = "lbTTMA";
            this.lbTTMA.Size = new System.Drawing.Size(151, 21);
            this.lbTTMA.TabIndex = 8;
            this.lbTTMA.Text = "Thông tin món ăn";
            // 
            // fChitietmonan
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(357, 473);
            this.Controls.Add(this.lbTTMA);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtCachlam);
            this.Controls.Add(this.txtNguyenlieu);
            this.Controls.Add(this.txtTenmon);
            this.Controls.Add(this.lbDongia);
            this.Controls.Add(this.lbCachlam);
            this.Controls.Add(this.lbNguyenlieu);
            this.Controls.Add(this.lbtenmon);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "fChitietmonan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fChitietmonan";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbtenmon;
        private DevExpress.XtraEditors.LabelControl lbNguyenlieu;
        private DevExpress.XtraEditors.LabelControl lbCachlam;
        private DevExpress.XtraEditors.LabelControl lbDongia;
        private System.Windows.Forms.TextBox txtTenmon;
        private System.Windows.Forms.TextBox txtNguyenlieu;
        private System.Windows.Forms.TextBox txtCachlam;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraEditors.LabelControl lbTTMA;
    }
}