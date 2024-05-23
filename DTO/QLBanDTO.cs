using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QLBanDTO
    {
        private int id;
        private string tenban;
        private string trangthai;

        public QLBanDTO(int id, string tenban, string trangthai)
        {
            this.Id = id;
            this.Tenban = tenban;
            this.Trangthai = trangthai;
        }
        public QLBanDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenban = "bàn số "+row["tenban"].ToString();
            this.Trangthai = ((int)row["trangthai"]==0)?"đang trống":"có người";
        }
        public int Id { get => id; set => id = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
