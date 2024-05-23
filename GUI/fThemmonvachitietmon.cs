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
    public partial class fThemmonvachitietmon : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        private string tenmon;
        private int iddanhmuc;
        private float gia;
        private int soluong;
        private int luachon=0;
        public int Id { get => id; set => id = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public int Iddanhmuc { get => iddanhmuc; set => iddanhmuc = value; }
        public float Gia { get => gia; set => gia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Luachon { get => luachon; set => luachon = value; }

        public fThemmonvachitietmon(ThucanDTO mon)
        {
            InitializeComponent();
            btnThemmon.Tag = mon;
        }
        private void btnThemmon_Click(object sender, EventArgs e)
        {
            this.Luachon = 1;
            this.Id = (btnThemmon.Tag as ThucanDTO).Id;
            this.Tenmon = (btnThemmon.Tag as ThucanDTO).Tenmon;
            this.Iddanhmuc = (btnThemmon.Tag as ThucanDTO).Iddanhmuc;
            this.Gia = (btnThemmon.Tag as ThucanDTO).Gia;
            this.Soluong = (int)nudSoluong.Value;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCTMA_Click(object sender, EventArgs e)
        {
            string ngl = "", ct = "";
            GetCTmonanBUS.Instance.GetCTmonan((btnThemmon.Tag as ThucanDTO).Id, ref ngl, ref ct);
            fChitietmonan f = new fChitietmonan((btnThemmon.Tag as ThucanDTO).Tenmon, ngl, ct, (btnThemmon.Tag as ThucanDTO).Gia);
            f.Location = this.Location;
            f.ShowDialog();
        }
    }
}