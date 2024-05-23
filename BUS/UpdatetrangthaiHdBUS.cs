using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UpdatetrangthaiHdBUS
    {
        private static UpdatetrangthaiHdBUS instance;

        public static UpdatetrangthaiHdBUS Instance { get { if (instance == null) instance = new UpdatetrangthaiHdBUS(); return UpdatetrangthaiHdBUS.instance; } private set => instance = value; }
        private UpdatetrangthaiHdBUS() { }
        public void UpdatetrangthaiHD(int idban)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_Updatetrangthaihoadon @idban",new object[] { idban});
        }
    }
}
