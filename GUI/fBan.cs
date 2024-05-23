using BUS;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fBan : DevExpress.XtraEditors.XtraForm
    {
        public fBan()
        {
            InitializeComponent();
            loadBan();
        }
        void loadBan()
        {
            flowLayoutPanel1.Controls.Clear();
            List<BanDTO> dsban = BanBUS.Instance.GetBan();
            foreach (BanDTO item in dsban)
            {
                Button btn = new Button() { Width = 200, Height = 150 };
                btn.Tag = item;
                btn.Text = "Bàn số "+item.Tenban.ToString();
                btn.Click += Btn_Click;
                switch (item.Trangthai)
                {
                    case 0:
                        {
                            btn.BackColor = System.Drawing.Color.FloralWhite;
                            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            btn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                            btn.ImageIndex = 0;
                            btn.ImageList = this.Hinhanh;
                            btn.Size = new System.Drawing.Size(212, 130);
                            btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                            btn.UseVisualStyleBackColor = true;
                            break;
                        }
                    default:
                        {
                            btn.BackColor = System.Drawing.Color.FloralWhite;
                            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            btn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                            btn.ImageIndex = 1;
                            btn.ImageList = this.Hinhanh;
                            btn.Size = new System.Drawing.Size(212, 130);
                            btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                            btn.UseVisualStyleBackColor = true;
                            break;
                        }
                        
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            BanDTO ban = btn.Tag as BanDTO;
            List<GetDsthemonDTO> dsmdc = GetmondachonBUS.Instance.Getdsthemmon();
            fDatMon f = new fDatMon(ban,dsmdc);
            f.FormClosing += F_FormClosing;
            f.ShowDialog();
        }

        private void F_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadBan();
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            loadBan();
        }

        private void btnBanTrong_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<BanDTO> dsban = BanBUS.Instance.GetBan();
            foreach (BanDTO item in dsban)
            {
                if (item.Trangthai == 0)
                {
                    Button btn = new Button() { Width = 200, Height = 150 };
                    btn.Tag = item;
                    btn.Text = "Bàn số " + item.Tenban.ToString();
                    btn.Click += Btn_Click;
                    btn.BackColor = System.Drawing.Color.FloralWhite;
                    btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                    btn.ImageIndex = 0;
                    btn.ImageList = this.Hinhanh;
                    btn.Size = new System.Drawing.Size(212, 130);
                    btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                    btn.UseVisualStyleBackColor = true;
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
        }

        private void btnBanconguoi_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<BanDTO> dsban = BanBUS.Instance.GetBan();
            foreach (BanDTO item in dsban)
            {
                if (item.Trangthai == 1)
                {
                    Button btn = new Button() { Width = 200, Height = 150 };
                    btn.Tag = item;
                    btn.Text = "Bàn số " + item.Tenban.ToString();
                    btn.Click += Btn_Click;
                    btn.BackColor = System.Drawing.Color.FloralWhite;
                    btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                    btn.ImageIndex = 1;
                    btn.ImageList = this.Hinhanh;
                    btn.Size = new System.Drawing.Size(212, 130);
                    btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                    btn.UseVisualStyleBackColor = true;
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}