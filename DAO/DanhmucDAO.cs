using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DanhmucDAO
    {
        private static DanhmucDAO instance;

        public static DanhmucDAO Instance { get { if (instance == null) instance = new DanhmucDAO();return DanhmucDAO.instance; } private set => instance = value; }
        private DanhmucDAO() { }
        public DataTable GetDanhmuc()
        {
            return DataProvider.Instance.ExtecuteQuery("USP_Danhmuc");
        }
        public DataTable Gettimdanhmuc(string tendanhmuc)
        {
            return DataProvider.Instance.ExtecuteQuery("USP_timdanhmuc @tendanhmuc",new object[] { tendanhmuc});
        }
    }
}
