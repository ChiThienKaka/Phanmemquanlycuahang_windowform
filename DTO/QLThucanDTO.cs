using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QLThucanDTO
    {
        private int id;
        private string tenmon;
        private int iddanhmuc;
        private string gia;
        CultureInfo culture = new CultureInfo("vi-Vn");
        public QLThucanDTO(int id, string tenmon, int iddanhmuc, string gia)
        {
            this.Id = id;
            this.Tenmon = tenmon;
            this.Iddanhmuc = iddanhmuc;
            this.Gia = gia;
        }
        public QLThucanDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenmon = row["tenmon"].ToString();
            this.Iddanhmuc = (int)row["iddanhmuc"];
            this.Gia = Convert.ToInt32(row["gia"]).ToString("c",culture).Split(',')[0]+" VNĐ";
        }
        public int Id { get => id; set => id = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public int Iddanhmuc { get => iddanhmuc; set => iddanhmuc = value; }
        public string Gia { get => gia; set => gia = value; }
    }
}
