using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DanhmucBUS
    {
        private static DanhmucBUS instance;

        public static DanhmucBUS Instance { get{ if (instance == null) instance = new DanhmucBUS(); return DanhmucBUS.instance; } private set => instance = value; }
        private DanhmucBUS() {  }
        public List<DanhmucDTO> GetDSDanhmuc() {
            List<DanhmucDTO> data = new List<DanhmucDTO>();
            foreach (DataRow item in DanhmucDAO.Instance.GetDanhmuc().Rows)
            {
                data.Add(new DanhmucDTO(item));
            }
            return data;
        }
        public List<DanhmucDTO> GetTimdanhmuc(string tendanhmuc)
        {
            List<DanhmucDTO> data = new List<DanhmucDTO>();
            foreach (DataRow item in DanhmucDAO.Instance.Gettimdanhmuc(tendanhmuc).Rows)
            {
                data.Add(new DanhmucDTO(item));
            }
            return data;
        }
        public void themDanhmuc(int id, string tendanhmuc)
        {
            DataProvider.Instance.ExtecuteQuery("USP_Themdanhmuc @id , @tendanhmuc", new object[] { id, tendanhmuc });
        }
        public void Capnhatdanhmuc(int id, string tendanhmuc)
        {
            DataProvider.Instance.ExtecuteQuery("USP_Capnhatdanhmuc @id , @tendanhmuc", new object[] {id, tendanhmuc });
        }
        public void Xoadanhmuc(int id)
        {
            DataProvider.Instance.ExtecuteQuery("USP_Xoadanhmuc @id", new object[] {id});
        }
    }
}
