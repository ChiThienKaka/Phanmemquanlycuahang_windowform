using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GetgiaBUS
    {
        private static GetgiaBUS instance;

        public static GetgiaBUS Instance { get { if (instance == null) instance = new GetgiaBUS(); return GetgiaBUS.instance; } private set => instance = value; }
        private GetgiaBUS() { }
        public float Getdongia(int id)
        {
            float dongia = 0;
            DataTable data = DataProvider.Instance.ExtecuteQuery("USP_Getdongia @id",new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                dongia = Convert.ToInt32(item["gia"]);
                break;
            }
            return dongia;
        }
    }
}
