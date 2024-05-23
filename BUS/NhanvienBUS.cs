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
    public class NhanvienBUS
    {
        private static NhanvienBUS instance;

        public static NhanvienBUS Instance { get { if (instance == null) instance = new NhanvienBUS();return NhanvienBUS.instance; } set => instance = value; }
        public List<NhanvienDTO> GetNhanvienList()
        {
            List<NhanvienDTO> data = new List<NhanvienDTO>();
            foreach (DataRow item in NhanvienDAO.Instance.GetNhanvien().Rows)
            {
                data.Add(new NhanvienDTO(item));
            }
            return data;
        }
        public List<NhanvienDTO> Gettimnhanvien(string name)
        {
            List<NhanvienDTO> data = new List<NhanvienDTO>();
            foreach (DataRow item in NhanvienDAO.Instance.Timnhanvien(name).Rows)
            {
                data.Add(new NhanvienDTO(item));
            }
            return data;
        }
        public DataTable GetNV_ToTK(string taikhoan)
        {
            return DataProvider.Instance.ExtecuteQuery("USP_ToTaiKhoan_GetNhanvien @taikhoan",new object[] { taikhoan});
        }
        public void Themnhanvien(string manv, string tennv, string chucvu, string diachi, string email, string sdt)
        {
            DataProvider.Instance.ExtecuteNonQuery("exec USP_Themnhanvien @maNV , @tenNV , @chucvu , @diachi , @email , @sdt", new object[] {manv,tennv,chucvu,diachi,email,sdt});
        }
        public void capnhatnhanvien(string manv, string ten, string chucvu, string diachi, string email, string sdt)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_updatenhanvien @manv , @tennv , @chucvu , @diachi , @email , @sdt",new object[] {manv,ten,chucvu,diachi,email,sdt });
        }
        public void xoanhanvien(string manv)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_deletenhanvien @manv", new object[] { manv });
        }
    }
}
