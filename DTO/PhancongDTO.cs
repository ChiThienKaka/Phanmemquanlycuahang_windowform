using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhancongDTO
    {
        private string maNV;
        private string tenNV;
        private string chucvu;
        private string nhiemvu;

        public PhancongDTO(string maNV, string tenNV, string chucvu, string nhiemvu)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.Chucvu = chucvu;
            this.Nhiemvu = nhiemvu;
        }
        public PhancongDTO(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["tenNV"].ToString();
            this.Chucvu = row["chucvu"].ToString();
            this.Nhiemvu = row["Nhiemvu"].ToString();
        }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Nhiemvu { get => nhiemvu; set => nhiemvu = value; }
    }
}
