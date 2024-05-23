
namespace GUI
{
    partial class fThemmonvachitietmon
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
            this.btnThemmon = new System.Windows.Forms.Button();
            this.btnCTMA = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnsoluong = new System.Windows.Forms.Button();
            this.nudSoluong = new System.Windows.Forms.NumericUpDown();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemmon
            // 
            this.btnThemmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemmon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThemmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemmon.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmon.Location = new System.Drawing.Point(112, 2);
            this.btnThemmon.Name = "btnThemmon";
            this.btnThemmon.Size = new System.Drawing.Size(93, 65);
            this.btnThemmon.TabIndex = 0;
            this.btnThemmon.Text = "Chọn món";
            this.btnThemmon.UseVisualStyleBackColor = false;
            this.btnThemmon.Click += new System.EventHandler(this.btnThemmon_Click);
            // 
            // btnCTMA
            // 
            this.btnCTMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCTMA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCTMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTMA.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTMA.Location = new System.Drawing.Point(2, 74);
            this.btnCTMA.Name = "btnCTMA";
            this.btnCTMA.Size = new System.Drawing.Size(207, 73);
            this.btnCTMA.TabIndex = 1;
            this.btnCTMA.Text = "Chi tiết món ăn";
            this.btnCTMA.UseVisualStyleBackColor = false;
            this.btnCTMA.Click += new System.EventHandler(this.btnCTMA_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.btnCTMA);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(211, 149);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnsoluong);
            this.panelControl3.Controls.Add(this.nudSoluong);
            this.panelControl3.Controls.Add(this.btnThemmon);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(207, 69);
            this.panelControl3.TabIndex = 2;
            // 
            // btnsoluong
            // 
            this.btnsoluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsoluong.Enabled = false;
            this.btnsoluong.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoluong.Location = new System.Drawing.Point(2, 2);
            this.btnsoluong.Name = "btnsoluong";
            this.btnsoluong.Size = new System.Drawing.Size(110, 42);
            this.btnsoluong.TabIndex = 2;
            this.btnsoluong.Text = "Số lượng";
            this.btnsoluong.UseVisualStyleBackColor = true;
            // 
            // nudSoluong
            // 
            this.nudSoluong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nudSoluong.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoluong.Location = new System.Drawing.Point(2, 44);
            this.nudSoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoluong.Name = "nudSoluong";
            this.nudSoluong.Size = new System.Drawing.Size(110, 23);
            this.nudSoluong.TabIndex = 1;
            this.nudSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnExit);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 147);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(211, 59);
            this.panelControl2.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(207, 55);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fThemmonvachitietmon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 206);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fThemmonvachitietmon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fThemmonvachitietmon";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemmon;
        private System.Windows.Forms.Button btnCTMA;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnExit;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btnsoluong;
        private System.Windows.Forms.NumericUpDown nudSoluong;
    }
}