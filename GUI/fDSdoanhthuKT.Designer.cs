
namespace GUI
{
    partial class fDSdoanhthuKT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDSdoanhthuKT));
            this.dgvDoanhthuct = new System.Windows.Forms.DataGridView();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ReportDT = new DevExpress.XtraEditors.SimpleButton();
            this.btnHdctt = new DevExpress.XtraEditors.SimpleButton();
            this.btnHddtt = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhthuct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDoanhthuct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDoanhthuct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoanhthuct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoanhthuct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDoanhthuct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoanhthuct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoanhthuct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoanhthuct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoanhthuct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhthuct.EnableHeadersVisualStyles = false;
            this.dgvDoanhthuct.Location = new System.Drawing.Point(2, 28);
            this.dgvDoanhthuct.MultiSelect = false;
            this.dgvDoanhthuct.Name = "dgvDoanhthuct";
            this.dgvDoanhthuct.ReadOnly = true;
            this.dgvDoanhthuct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDoanhthuct.RowHeadersVisible = false;
            this.dgvDoanhthuct.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen;
            this.dgvDoanhthuct.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDoanhthuct.RowTemplate.Height = 24;
            this.dgvDoanhthuct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhthuct.Size = new System.Drawing.Size(1427, 565);
            this.dgvDoanhthuct.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(717, 28);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(151, 49);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem tất cả";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl1.Controls.Add(this.dgvDoanhthuct);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1431, 674);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Bảng doanh thu chi tiết";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ReportDT);
            this.groupControl2.Controls.Add(this.btnHdctt);
            this.groupControl2.Controls.Add(this.btnHddtt);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.btnXem);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(2, 593);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1427, 79);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Chức năng";
            // 
            // ReportDT
            // 
            this.ReportDT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ReportDT.ImageOptions.Image")));
            this.ReportDT.Location = new System.Drawing.Point(1031, 28);
            this.ReportDT.Name = "ReportDT";
            this.ReportDT.Size = new System.Drawing.Size(151, 49);
            this.ReportDT.TabIndex = 7;
            this.ReportDT.Text = "Report";
            this.ReportDT.Click += new System.EventHandler(this.ReportDT_Click);
            // 
            // btnHdctt
            // 
            this.btnHdctt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHdctt.ImageOptions.Image")));
            this.btnHdctt.Location = new System.Drawing.Point(874, 28);
            this.btnHdctt.Name = "btnHdctt";
            this.btnHdctt.Size = new System.Drawing.Size(151, 49);
            this.btnHdctt.TabIndex = 6;
            this.btnHdctt.Text = "Chưa thanh toán";
            this.btnHdctt.Click += new System.EventHandler(this.btnHdctt_Click);
            // 
            // btnHddtt
            // 
            this.btnHddtt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHddtt.ImageOptions.Image")));
            this.btnHddtt.Location = new System.Drawing.Point(560, 28);
            this.btnHddtt.Name = "btnHddtt";
            this.btnHddtt.Size = new System.Drawing.Size(151, 49);
            this.btnHddtt.TabIndex = 5;
            this.btnHddtt.Text = "Đã thanh toán";
            this.btnHddtt.Click += new System.EventHandler(this.btnHddtt_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số dòng: ";
            // 
            // fDSdoanhthuKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 674);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("fDSdoanhthuKT.IconOptions.Image")));
            this.Name = "fDSdoanhthuKT";
            this.Text = "Hệ thống kế toán";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhthuct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnHdctt;
        private DevExpress.XtraEditors.SimpleButton btnHddtt;
        private System.Windows.Forms.DataGridView dgvDoanhthuct;
        private DevExpress.XtraEditors.SimpleButton ReportDT;
    }
}