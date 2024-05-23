using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GetDsthemonDTO
    {
        private int idban;
        private int idthucan;
        private int soluong;
        private float tongtien;
        private int trangthai;
        public GetDsthemonDTO(int idban, int idthucan, int soluong, float tongtien, int trangthai)
        {
            this.Idban = idban;
            this.Idthucan = idthucan;
            this.Soluong = soluong;
            this.Tongtien = tongtien;
            this.Trangthai = trangthai;
        }
        public GetDsthemonDTO(DataRow row)
        {
            this.Idban = (int)row["idban"];
            this.Idthucan = (int)row["idthucan"];
            this.Soluong = (int)row["soluong"];
            this.Tongtien = Convert.ToInt32(row["tongtien"]);
            this.Trangthai = (int)row["trangthai"];
        }
        public int Idban { get => idban; set => idban = value; }
        public int Idthucan { get => idthucan; set => idthucan = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Tongtien { get => tongtien; set => tongtien = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
    }
}
