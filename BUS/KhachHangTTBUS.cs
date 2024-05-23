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
    public class KhachHangTTBUS
    {
        private static KhachHangTTBUS instance;

        public static KhachHangTTBUS Instance { get { if (instance == null) instance = new KhachHangTTBUS();return KhachHangTTBUS.instance; } private set => instance = value; }
        private KhachHangTTBUS() { }
        public void ThemKhachHang(string makh, string tenkh, string diachi, string sdt, byte[]anh)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_ThemKhachHangThanthiet @makh , @tenkh , @diachi , @sdt , @anh",new object[] {makh,tenkh,diachi,sdt,anh });
        }
        public void CapnhatKhachHang(string makh, string tenkh, string diachi, string sdt, byte[] anh)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_CapnhatKhachHangThanthiet @makh , @tenkh , @diachi , @sdt , @anh", new object[] { makh, tenkh, diachi, sdt, anh });
        }
        public void XoaKhachHang(string makh)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_XoaKhachHangThanthiet @makh", new object[] { makh});
        }
        public DataTable BangTimSDT(string sdt)
        {
            return DataProvider.Instance.ExtecuteQuery("USP_TimKhachHangThanThiet @sdt",new object[] {sdt });
        }
        public DataTable BangKhangHangTT()
        {
            return KhachHangTTDAO.Instance.BangKhachhangthanthiet();
        }
    }
}
