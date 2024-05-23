using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UpdateTrangthaibanThanhtoanBUS
    {
        private static UpdateTrangthaibanThanhtoanBUS instance;

        public static UpdateTrangthaibanThanhtoanBUS Instance { get { if (instance == null) instance = new UpdateTrangthaibanThanhtoanBUS(); return UpdateTrangthaibanThanhtoanBUS.instance; } private set => instance = value; }
        private UpdateTrangthaibanThanhtoanBUS() { }
        public void Updatetrangthaibanthanhtoan(int idban)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_UpdatetrangthaibanThanhtoan @idban", new object[] {idban });
        }
    }
}
