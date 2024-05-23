using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GettenmonBUS
    {
        private static GettenmonBUS instance;

        public static GettenmonBUS Instance { get { if (instance == null) instance = new GettenmonBUS(); return GettenmonBUS.instance; } private set => instance = value; }
        private GettenmonBUS() { }
        public string Gettenmon(int id)
        {
            string tenmon="";
            DataTable data = DataProvider.Instance.ExtecuteQuery("USP_Gettenmon @id",new object[] {id });
            foreach (DataRow item in data.Rows)
            {
                tenmon = item["tenmon"].ToString();
                break;
            }
            return tenmon;
        }
    }
}
