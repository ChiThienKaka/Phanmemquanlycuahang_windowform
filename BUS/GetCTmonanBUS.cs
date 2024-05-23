using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GetCTmonanBUS
    {
        private static GetCTmonanBUS instance;

        public static GetCTmonanBUS Instance { get { if (instance == null) instance = new GetCTmonanBUS(); return GetCTmonanBUS.instance; } private set => instance = value; }
        private GetCTmonanBUS() { }
        public void GetCTmonan(int id, ref string ngl, ref string ct)
        {
            foreach (DataRow item in CTmonanDAO.Instance.CTMoan(id).Rows)
            {
                ngl = item["nguyenlieu"].ToString();
                ct = item["congthuc"].ToString();
                break;
            }
        }
        public List<QLCTmonanDTO> CTmonan()
        {
            List<QLCTmonanDTO> data = new List<QLCTmonanDTO>();
            foreach (DataRow item in CTmonanDAO.Instance.QLchitietmonan().Rows)
            {
                data.Add(new QLCTmonanDTO(item));
            }
            return data;
        }
        public List<QLCTmonanDTO> TimCTmonan(string tennguyenlieu)
        {
            List<QLCTmonanDTO> data = new List<QLCTmonanDTO>();
            foreach (DataRow item in CTmonanDAO.Instance.TimQLchitietmonan(tennguyenlieu).Rows)
            {
                data.Add(new QLCTmonanDTO(item));
            }
            return data;
        }
        public void ThemCTmon(int idthucan, string nguyenlieu, string congthuc)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_ThemCTMonan @idthucan , @nguyenlieu , @congthuc", new object[] {idthucan,nguyenlieu,congthuc });
        }
        public void CapnhatCTmon(int idthucan, string nguyenlieu, string congthuc)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_CapNhatCTMonan @idthucan , @nguyenlieu , @congthuc", new object[] { idthucan, nguyenlieu, congthuc });
        }
        public void XoaCTmon(int idthucan)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_XoaCTMonan @idthucan", new object[] { idthucan});
        }
    }
}
