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
    public class ThucanBUS
    {
        private static ThucanBUS instance;
        public static ThucanBUS Instance { get { if (instance == null) instance = new ThucanBUS(); return ThucanBUS.instance; } private set => instance = value; }
        private ThucanBUS() { }
        public List<ThucanDTO> Thucan()
        {
            List<ThucanDTO> dsta = new List<ThucanDTO>();
            foreach (DataRow item in ThucanDAO.Instance.ThucAn().Rows)
            {
                ThucanDTO ta = new ThucanDTO(item);
                dsta.Add(ta);
            }
            return dsta;
        }
        public List<QLThucanDTO> QLThucan()
        {
            List<QLThucanDTO> dsta = new List<QLThucanDTO>();
            foreach (DataRow item in ThucanDAO.Instance.ThucAn().Rows)
            {
                QLThucanDTO ta = new QLThucanDTO(item);
                dsta.Add(ta);
            }
            return dsta;
        }
        public List<QLThucanDTO> TimThucan(string tenthucan)
        {
            List<QLThucanDTO> dsta = new List<QLThucanDTO>();
            foreach (DataRow item in ThucanDAO.Instance.TimThucan(tenthucan).Rows)
            {
                QLThucanDTO ta = new QLThucanDTO(item);
                dsta.Add(ta);
            }
            return dsta;
        }
        public void Themthucan(int id, string tenmon, int madm, float gia)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_Themthucan @id , @tenmon , @iddanhmuc , @gia", new object[] {id,tenmon,madm,gia });
        }
        public void Capnhatthucan(int id, string tenmon, int madm, float gia)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_Capnhatthucan @id , @tenmon , @iddanhmuc , @gia", new object[] { id, tenmon, madm, gia });
        }
        public void XoaThucan(int id)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_Xoathucan @id", new object[] { id});
        }
    }
}
