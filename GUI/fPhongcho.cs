using DevExpress.XtraEditors;
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
    public partial class fPhongcho : DevExpress.XtraEditors.XtraForm
    {
        public fPhongcho()
        {
            InitializeComponent();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            progressBarControl1.PerformStep();
            if (i == 3)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}