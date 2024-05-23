using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class InCThoadonBUS
    {
        private static InCThoadonBUS instance;

        public static InCThoadonBUS Instance { get { if (instance == null) instance = new InCThoadonBUS(); return InCThoadonBUS.instance; } set => instance = value; }
        private InCThoadonBUS() { }
        public void InCThoadon(int idthucan, int soluong, float tongtien, int giamgia)
        {
            DataProvider.Instance.ExtecuteNonQuery("exec USP_InCThoadon @idthucan , @soluong , @tongtien , @giamgia",new object[] {idthucan,soluong,tongtien,giamgia });
        }
    }
}
