using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QLCTmonanDTO
    {
        private int idthucan;
        private string nguyenlieu;
        private string congthuc;

        public QLCTmonanDTO(int idthucan,string tenmon, string nguyenlieu, string congthuc)
        {
            this.Idthucan = idthucan;
            this.Nguyenlieu = nguyenlieu;
            this.Congthuc = congthuc;
        }
        public QLCTmonanDTO(DataRow row)
        {
            this.Idthucan = (int)row["idthucan"];
            this.Nguyenlieu = row["nguyenlieu"].ToString();
            this.Congthuc = row["congthuc"].ToString();
        }

        public int Idthucan { get => idthucan; set => idthucan = value; }
        public string Nguyenlieu { get => nguyenlieu; set => nguyenlieu = value; }
        public string Congthuc { get => congthuc; set => congthuc = value; }
        
    }
}
