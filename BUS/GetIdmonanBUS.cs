using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GetIdmonanBUS
    {
        private static GetIdmonanBUS instance;

        public static GetIdmonanBUS Instance { get { if (instance == null) instance = new GetIdmonanBUS(); return GetIdmonanBUS.instance; } private set => instance = value; }
        private GetIdmonanBUS() { }
        public int GetIdmonan(string tenmon)
        {
            int idmonan = 0;
            DataTable data = DataProvider.Instance.ExtecuteQuery("exec USP_Idmonan @tenmon",new object[] {tenmon });
            foreach (DataRow item in data.Rows)
            {
                idmonan = (int)item["id"];
                break;
            }
            return idmonan;
        }
    }
}
