using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanvienDAO
    {
        private static NhanvienDAO instance;

        public static NhanvienDAO Instance { get { if (instance == null) instance = new NhanvienDAO();return NhanvienDAO.instance; } private set => instance = value; }
        public DataTable GetNhanvien()
        {
            return DataProvider.Instance.ExtecuteQuery(" exec USP_Danhsachnhanvien");
        }
        public DataTable Timnhanvien(string name)
        {
            return DataProvider.Instance.ExtecuteQuery("USP_timtennhanvien @tenhienthi",new object[] {name });
        }
    }
}
