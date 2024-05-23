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
    public class PhancongBUS
    {
        private static PhancongBUS instance;

        public static PhancongBUS Instance { get { if (instance == null) instance = new PhancongBUS();return PhancongBUS.instance; } private set => instance = value; }
        private PhancongBUS() { }
        public List<PhancongDTO> GetBangPhanConglist()
        {
            List<PhancongDTO> list = new List<PhancongDTO>();
            foreach (DataRow item in PhancongDAO.Instance.BangPhanCong().Rows)
            {
                list.Add(new PhancongDTO(item));
            }
            return list;
        }
        public void ThemPhanCong(string manv,string nhiemvu)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_ThemPhanCong @manv , @nhiemvu", new object[] {manv,nhiemvu });
        }
        public void CapnhatPhanCong(string manv,string nhiemvu)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_CapnhatPhancong @manv , @nhiemvu", new object[] {manv,nhiemvu });
        }
        public void XoaPhanCong(string manv)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_XoaPhanCong @manv", new object[] { manv });
        }
        public List<PhancongDTO> TimPhanCong(string tenNV)
        {
            List<PhancongDTO> list = new List<PhancongDTO>();
            foreach ( DataRow item in PhancongDAO.Instance.Timbangphancong(tenNV).Rows)
            {
                list.Add(new PhancongDTO(item));
            }
            return list;
        }
    }
}
