using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangTTDAO
    {
        private static KhachHangTTDAO instance;

        public static KhachHangTTDAO Instance { get { if (instance == null) instance = new KhachHangTTDAO(); return KhachHangTTDAO.instance; } private set => instance = value; }
        private KhachHangTTDAO() { }
        public DataTable BangKhachhangthanthiet()
        {
            return DataProvider.Instance.ExtecuteQuery("USP_KhachHangThanThiet");
        }
    }
}
