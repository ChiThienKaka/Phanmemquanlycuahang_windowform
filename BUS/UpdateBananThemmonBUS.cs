using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UpdateBananThemmonBUS
    {
        private static UpdateBananThemmonBUS instance;

        public static UpdateBananThemmonBUS Instance { get { if (instance == null) instance = new UpdateBananThemmonBUS(); return UpdateBananThemmonBUS.instance; } private set => instance = value; }
        private UpdateBananThemmonBUS() { }
        public void UpdateBanthemmon(int idban)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_Updatetrangthaiban @idban", new object[] { idban });
        }
    }
}
