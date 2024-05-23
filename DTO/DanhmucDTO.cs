using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhmucDTO
    {
        private int maDM;
        private string tenDM;

        public DanhmucDTO(int maDM, string tenDM)
        {
            this.MaDM = maDM;
            this.TenDM = tenDM;
        }
        public DanhmucDTO(DataRow row)
        {
            this.MaDM = (int)row["id"];
            this.TenDM = row["tendanhmuc"].ToString();
        }
        public int MaDM { get => maDM; set => maDM = value; }
        public string TenDM { get => tenDM; set => tenDM = value; }
    }
}
