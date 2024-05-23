using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DoanhthuctDAO
    {
        private static DoanhthuctDAO instance;

        public static DoanhthuctDAO Instance { get { if (instance == null) instance = new DoanhthuctDAO(); return DoanhthuctDAO.instance; } private set => instance = value; }
        public DataTable Getdoanhthuct()
        {
            return DataProvider.Instance.ExtecuteQuery("exec USP_DoanhthuChiTiet");
        }
        public DataTable GetDoanhthudathanhtoan()
        {
            return DataProvider.Instance.ExtecuteQuery("exec USP_DoanhthuDathanhtoan");
        }
        public DataTable GetDoanhthuchuathanhtoan()
        {
            return DataProvider.Instance.ExtecuteQuery("exec USP_Doanhthuchuathanhtoan");
        }
    }
}
