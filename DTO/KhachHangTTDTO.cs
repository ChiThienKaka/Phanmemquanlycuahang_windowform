using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangTTDTO
    {
        private string maKH;
        private string tenKH;
        private string diaChi;
        private string sdt;
        private byte[] anh;

        public KhachHangTTDTO(string maKH, string tenKH, string diaChi, string sdt, byte[] anh)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.Anh = anh;
        }
        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public byte[] Anh { get => anh; set => anh = value; }
    }
}
