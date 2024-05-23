using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DoanhthutheongayktBUS
    {
        private static DoanhthutheongayktBUS instance;

        public static DoanhthutheongayktBUS Instance { get { if (instance == null) instance = new DoanhthutheongayktBUS();return DoanhthutheongayktBUS.instance; } private set => instance = value; }
        private DoanhthutheongayktBUS() { }
        public DataTable Doanhthutheongay(DateTime ngayvao, DateTime ngayra)
        {
            return DataProvider.Instance.ExtecuteQuery("exec USP_TinhtongtienTheongay @ngayvao , @ngayra", new object[] { ngayvao, ngayra });
        }
    }
}
