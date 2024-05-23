using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class luongDAO
    {
        private static luongDAO instance;

        public static luongDAO Instance { get { if (instance == null) instance = new luongDAO();return luongDAO.instance; } private set => instance = value; }
        private luongDAO() { }
        public DataTable Getluongnv()
        {
            return DataProvider.Instance.ExtecuteQuery("USP_Luongnhanvien");
        }
        public DataTable timtenhienthitrongluong(string tenhienthi)
        {
            return DataProvider.Instance.ExtecuteQuery("USP_timtentrongluong @tenhienthi", new object[] { tenhienthi });
        }
    }
}
