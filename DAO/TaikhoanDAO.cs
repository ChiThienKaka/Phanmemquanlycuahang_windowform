using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaikhoanDAO
    {
        private static TaikhoanDAO instance;

        public static TaikhoanDAO Instance {
            get { if (instance == null)instance = new TaikhoanDAO(); return TaikhoanDAO.instance; } 
            private set => instance = value; }
        private TaikhoanDAO() { }
        public DataTable TaiKhoan()
        {
            return DataProvider.Instance.ExtecuteQuery("USP_TableTaikhoan");
        }
        public DataTable Timtaikhoan(string name)
        {
            return DataProvider.Instance.ExtecuteQuery("USP_timtentaikhoan @tenhienthi", new object[] { name });
        }
    }
}
