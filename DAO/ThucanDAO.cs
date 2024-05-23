using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThucanDAO
    {
        private static ThucanDAO instance;

        public static ThucanDAO Instance { get { if (instance == null) instance = new ThucanDAO(); return ThucanDAO.instance; } private set => instance = value; }
        private ThucanDAO() { }
        public DataTable ThucAn()
        {
            return DataProvider.Instance.ExtecuteQuery("USP_ThucAn");
        }
        public DataTable TimThucan(string tenthucan)
        {
            return DataProvider.Instance.ExtecuteQuery("USP_timtenthucan @tenthucan", new object[] { tenthucan });
        }
    }
}
