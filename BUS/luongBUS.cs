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
    public class luongBUS
    {
        private static luongBUS instance;

        public static luongBUS Instance { get { if (instance == null) instance = new luongBUS(); return luongBUS.instance; } private set => instance = value; }
        private luongBUS() { }
        public List<luongDTO> GetLuongnv()
        {
            List<luongDTO> data = new List<luongDTO>();
            foreach (DataRow item in luongDAO.Instance.Getluongnv().Rows)
            {
                data.Add(new luongDTO(item));
            }
            return data;
        }
        public void themluongmoi(string manv, float luong1ngay, int songay, int ngaynghi, float phucap, int diemchuyencan)
        {
            DataProvider.Instance.ExtecuteQuery("USP_ThemLuongMoi @manv , @luong1ngay , @songay , @ngaynghi , @phucap , @diemchuyencan", new object[] {manv,luong1ngay,songay,ngaynghi,phucap,diemchuyencan });
        }
        public void capnhatluong(string manv, float luong1ngay, int songay, int ngaynghi, float phucap, int diemchuyencan)
        {
            DataProvider.Instance.ExtecuteQuery("USP_Capnhatluong @manv , @luong1ngay , @songay , @ngaynghi , @phucap , @diemchuyencan", new object[] { manv, luong1ngay, songay, ngaynghi, phucap, diemchuyencan });
        }
        public void xoaluong(string manv)
        {
            DataProvider.Instance.ExtecuteQuery("USP_Xoaluong @manv", new object[] { manv});
        }
        public List<luongDTO> timtenhienthiinluong(string tenhienthi)
        {
            List<luongDTO> data = new List<luongDTO>();
            foreach (DataRow item in luongDAO.Instance.timtenhienthitrongluong(tenhienthi).Rows)
            {
                data.Add(new luongDTO(item));
            }
            return data;
        }
    }
}
