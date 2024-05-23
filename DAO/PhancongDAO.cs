using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhancongDAO
    {
        private static PhancongDAO instance;

        public static PhancongDAO Instance { get { if (instance == null) instance = new PhancongDAO();return PhancongDAO.instance; } private set => instance = value; }
        private PhancongDAO() { }
        public DataTable BangPhanCong()
        {
            return DataProvider.Instance.ExtecuteQuery("USP_PhanCong");
        }
        public DataTable Timbangphancong(string tennvBPC)
        {
            return DataProvider.Instance.ExtecuteQuery("USP_timtenphancong @tenNV", new object[] { tennvBPC });
        }
    }
}
