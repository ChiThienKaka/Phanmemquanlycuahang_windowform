using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class InHoaDonBUS
    {
        private static InHoaDonBUS instance;
        public static InHoaDonBUS Instance { get { if (instance == null) instance = new InHoaDonBUS();return InHoaDonBUS.instance; } private set => instance = value; }
        private InHoaDonBUS() { }
        public void Inhoadon(int idtable)
        {
            DataProvider.Instance.ExtecuteNonQuery(@"exec USP_InHoaDon @idban",new object[] { idtable});
        }
    }
}
