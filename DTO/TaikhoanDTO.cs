using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaikhoanDTO
    {
        private string taikhoan;
        private string tenhienthi;
        private string matkhau;
        private int loaiTK;
        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Tenhienthi { get => tenhienthi; set => tenhienthi = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int LoaiTK { get => loaiTK; set => loaiTK = value; }
        public TaikhoanDTO(string tk, string tht, string mk, int ltk)
        {
            this.Taikhoan = tk;
            this.Tenhienthi = tht;
            this.Matkhau = mk;
            this.LoaiTK = ltk;
        }
        public TaikhoanDTO(DataRow rows)
        {
            this.Taikhoan = rows["taikhoan"].ToString();
            this.Tenhienthi = rows["tenhienthi"].ToString();
            this.Matkhau = rows["matkhau"].ToString();
            this.LoaiTK = (int)rows["loaiTK"];
        }
    }
}
