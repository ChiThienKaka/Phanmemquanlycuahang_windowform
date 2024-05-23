using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThucanDTO
    {
        private int id;
        private string tenmon;
        private int iddanhmuc;
        private float gia;
        public ThucanDTO() { }
        public ThucanDTO(int id, string tenmon, int iddanhmuc, float gia)
        {
            this.Id = id;
            this.Tenmon = tenmon;
            this.Iddanhmuc = iddanhmuc;
            this.Gia = gia;
        }
        public ThucanDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenmon = row["tenmon"].ToString();
            this.Iddanhmuc = (int)row["iddanhmuc"];
            this.Gia = Convert.ToInt32(row["Gia"]);
        }
        public int Id { get => id; set => id = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public int Iddanhmuc { get => iddanhmuc; set => iddanhmuc = value; }
        public float Gia { get => gia; set => gia = value; }
    }
}
