
namespace GUI
{
    partial class fDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangnhap));
            this.lbTK = new DevExpress.XtraEditors.LabelControl();
            this.lbMK = new DevExpress.XtraEditors.LabelControl();
            this.txtTK = new DevExpress.XtraEditors.TextEdit();
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.btnDangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.checkHTMK = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkHTMK.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTK
            // 
            this.lbTK.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.Appearance.Options.UseFont = true;
            this.lbTK.Location = new System.Drawing.Point(6, 53);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(83, 21);
            this.lbTK.TabIndex = 0;
            this.lbTK.Text = "Tài khoản: ";
            // 
            // lbMK
            // 
            this.lbMK.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.Appearance.Options.UseFont = true;
            this.lbMK.Location = new System.Drawing.Point(6, 98);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(74, 21);
            this.lbMK.TabIndex = 1;
            this.lbMK.Text = "Mật khẩu:";
            // 
            // txtTK
            // 
            this.txtTK.EditValue = "";
            this.txtTK.Location = new System.Drawing.Point(95, 49);
            this.txtTK.Name = "txtTK";
            this.txtTK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Properties.Appearance.Options.UseFont = true;
            this.txtTK.Size = new System.Drawing.Size(298, 28);
            this.txtTK.TabIndex = 2;
            // 
            // txtMK
            // 
            this.txtMK.EditValue = "";
            this.txtMK.Location = new System.Drawing.Point(95, 94);
            this.txtMK.Name = "txtMK";
            this.txtMK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Properties.Appearance.Options.UseFont = true;
            this.txtMK.Properties.UseSystemPasswordChar = true;
            this.txtMK.Size = new System.Drawing.Size(298, 28);
            this.txtMK.TabIndex = 3;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Appearance.Options.UseFont = true;
            this.btnDangnhap.Location = new System.Drawing.Point(151, 183);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(103, 34);
            this.btnDangnhap.TabIndex = 4;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // checkHTMK
            // 
            this.checkHTMK.Location = new System.Drawing.Point(260, 142);
            this.checkHTMK.Name = "checkHTMK";
            this.checkHTMK.Properties.Caption = "Hiển thị mật khẩu";
            this.checkHTMK.Size = new System.Drawing.Size(133, 24);
            this.checkHTMK.TabIndex = 5;
            this.checkHTMK.CheckedChanged += new System.EventHandler(this.checkHTMK_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDangnhap);
            this.groupBox1.Controls.Add(this.lbTK);
            this.groupBox1.Controls.Add(this.txtTK);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.lbMK);
            this.groupBox1.Controls.Add(this.checkHTMK);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 229);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // fDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 229);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("fDangnhap.IconOptions.Image")));
            this.Name = "fDangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkHTMK.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbTK;
        private DevExpress.XtraEditors.LabelControl lbMK;
        private DevExpress.XtraEditors.TextEdit txtTK;
        private DevExpress.XtraEditors.TextEdit txtMK;
        private DevExpress.XtraEditors.SimpleButton btnDangnhap;
        private DevExpress.XtraEditors.CheckEdit checkHTMK;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}