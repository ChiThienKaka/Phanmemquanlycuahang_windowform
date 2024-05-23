using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MondachonDAO
    {
        private static MondachonDAO instance;

        public static MondachonDAO Instance { get { if (instance == null) instance = new MondachonDAO(); return MondachonDAO.instance; } private set => instance = value; }
        private MondachonDAO() { }
        public DataTable Getmondachon()
        {
            return DataProvider.Instance.ExtecuteQuery("USP_DSMonDachon");
        }
    }
}
