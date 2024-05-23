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
    public class TaikhoanBUS
    {
        private static TaikhoanBUS instance;
        public static TaikhoanBUS Instance {
            get { if (instance == null) instance = new TaikhoanBUS();return TaikhoanBUS.instance; }
            private set => instance = value; }
        private TaikhoanBUS() { }
        public List<TaikhoanDTO> DangNhap()
        {
            List<TaikhoanDTO> dstk = new List<TaikhoanDTO>();
            
            foreach (DataRow item in TaikhoanDAO.Instance.TaiKhoan().Rows)
            {
                TaikhoanDTO tk = new TaikhoanDTO(item);
                dstk.Add(tk);
            }
            return dstk;
        }
        public List<TaikhoanDTO> Timtaikhoan(string name)
        {
            List<TaikhoanDTO> data = new List<TaikhoanDTO>();
            foreach (DataRow item in TaikhoanDAO.Instance.Timtaikhoan(name).Rows)
            {
                data.Add(new TaikhoanDTO(item));
            }
            return data;
        }
        public void Doitaikhoanmatkhau(string taikhoan, string matkhau)
        {
            DataProvider.Instance.ExtecuteQuery("USP_Capnhattaikhoanmatkhau @taikhoan , @matkhau", new object[] { taikhoan, matkhau });
        }
        public void Capnhattaikhoan(string taikhoan, string tenhienthi, string matkhau, int loaitk)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_Capnhattaikhoan @taikhoan , @tenhienthi , @matkhau , @loaitk", new object[] {taikhoan,tenhienthi,matkhau,loaitk});
        }
        public void Xoataikhoan(string taikhoan)
        {
            DataProvider.Instance.ExtecuteNonQuery("Usp_Xoataikhoan @taikhoan",new object[] {taikhoan });
        }
        public void ThemTaikhoan(string taikhoan, string tenthienthi, string matkhau, int loaitk)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_Themtaikhoan @taikhoan , @tenhienthi , @matkhau , @loaitk",new object[] {taikhoan,tenthienthi,matkhau,loaitk });
        }
    }
}
