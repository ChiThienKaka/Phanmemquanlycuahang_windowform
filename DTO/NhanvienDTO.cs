using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanvienDTO
    {
        private string maNV;
        private string tenNV;
        private string chucvu;
        private string diachi;
        private string email;
        private string sdt;
        public NhanvienDTO(string maNV, string tenNV, string chucvu, string diachi, string email, string sdt)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.Chucvu = chucvu;
            this.Diachi = diachi;
            this.Email = email;
            this.Sdt = sdt;
        }
        public NhanvienDTO(DataRow row)
        {
            this.MaNV = row["maNV"].ToString();
            this.TenNV = row["tenNV"].ToString();
            this.Chucvu = row["chucvu"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.Email = row["email"].ToString();
            this.Sdt = row["sdt"].ToString();
        }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
