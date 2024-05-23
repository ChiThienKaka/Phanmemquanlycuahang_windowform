using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BanDAO
    {
        private static BanDAO instance;
        public static BanDAO Instance { get { if (instance == null) instance = new BanDAO();return BanDAO.instance; } 
            private set => instance = value; }
        private BanDAO() { }
        public DataTable TableBan()
        {
            return DataProvider.Instance.ExtecuteQuery("USP_TableBan");
        }
        public DataTable TimBan(int tenban)
        {
            return DataProvider.Instance.ExtecuteQuery("USP_TimBan @tenban",new object[] {tenban });
        }
    }
}
