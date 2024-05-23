using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fChitietmonan : DevExpress.XtraEditors.XtraForm
    {
        CultureInfo culture = new CultureInfo("vi-Vn");
        public fChitietmonan(string tenmon,string ngl,string ct, float gia)
        {
            InitializeComponent();
            txtTenmon.Text = tenmon;
            txtNguyenlieu.Text = ngl;
            txtCachlam.Text = ct;
            lbDongia.Text= gia.ToString("c",culture).Split(',')[0]+" VNĐ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}