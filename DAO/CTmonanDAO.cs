using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CTmonanDAO
    {
        private static CTmonanDAO instance;

        public static CTmonanDAO Instance { get { if (instance == null) instance = new CTmonanDAO(); return CTmonanDAO.instance; } private set => instance = value; }
        private CTmonanDAO(){}
        public DataTable CTMoan(int idthucan)
        {
            return  DataProvider.Instance.ExtecuteQuery("USP_CTMonan @idmon",new object[] { idthucan});
        }
        public DataTable QLchitietmonan()
        {
            return DataProvider.Instance.ExtecuteQuery("USP_ChitietThucan");
        }
        public DataTable TimQLchitietmonan(string tennguyenlieu)
        {
            return DataProvider.Instance.ExtecuteQuery("USP_timnguyenlieu @tennguyenlieu",new object[] {tennguyenlieu });
        }
    }
}
