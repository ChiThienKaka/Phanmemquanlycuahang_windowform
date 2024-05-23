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
    public class BanBUS
    {
        private static BanBUS instance;

        public static BanBUS Instance { get { if (instance == null) instance = new BanBUS(); return BanBUS.instance; } private set => instance = value; }
        private BanBUS() { }
        public List<BanDTO> GetBan()
        {
            List<BanDTO> dsban = new List<BanDTO>();
            foreach (DataRow item in BanDAO.Instance.TableBan().Rows)
            {
                BanDTO ban = new BanDTO(item);
                dsban.Add(ban);
            }
            return dsban;
        }
        public List<QLBanDTO> GetQLBan()
        {
            List<QLBanDTO> dsban = new List<QLBanDTO>();
            foreach (DataRow item in BanDAO.Instance.TableBan().Rows)
            {
                dsban.Add(new QLBanDTO(item));
            }
            return dsban;
        }
        public List<QLBanDTO> timban(int tenban)
        {
            List<QLBanDTO> dsban = new List<QLBanDTO>();
            foreach (DataRow item in BanDAO.Instance.TimBan(tenban).Rows)
            {
                dsban.Add(new QLBanDTO(item));
            }
            return dsban;
        }
        public void themban(int id, int tenban, int trangthai)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_Themban @idban , @tenban , @trangthai",new object[] {id,tenban,trangthai});
        }
        public void capnhatban(int id, int tenban, int trangthai)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_Capnhatban @idban , @tenban , @trangthai", new object[] { id, tenban, trangthai });
        }
        public void Xoaban(int id,int trangthai)
        {
            DataProvider.Instance.ExtecuteNonQuery("USP_Xoaban @idban , @trangthai", new object[] { id,trangthai });
        }
    }
}
