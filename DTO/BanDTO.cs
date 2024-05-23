using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BanDTO
    {
        private int id;
        private int tenban;
        private int trangthai;
        public BanDTO(int id,int tenban,int trangthai)
        {
            this.Id = id;
            this.Tenban = tenban;
            this.Trangthai = trangthai;
        }
        public BanDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenban = (int)row["tenban"];
            this.Trangthai = (int)row["trangthai"];
        }
        public int Id { get => id; set => id = value; }
        public int Tenban { get => tenban; set => tenban = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
    }
}
