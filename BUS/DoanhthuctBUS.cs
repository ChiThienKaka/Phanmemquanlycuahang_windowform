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
    public class DoanhthuctBUS
    {
        private static DoanhthuctBUS instance;

        public static DoanhthuctBUS Instance { get { if (instance == null) instance = new DoanhthuctBUS(); return DoanhthuctBUS.instance; } private set => instance = value; }
        public List<CTdoanhthuDTO> Getdoanhthuchitiet()
        {
            List<CTdoanhthuDTO> data = new List<CTdoanhthuDTO>();
            foreach (DataRow item in DoanhthuctDAO.Instance.Getdoanhthuct().Rows)
            {
                data.Add(new CTdoanhthuDTO(item));
            }
            return data;
        }
        public List<CTdoanhthuDTO> GetDoanhthudathanhtoanroi()
        {
            List<CTdoanhthuDTO> data = new List<CTdoanhthuDTO>();
            foreach (DataRow item in DoanhthuctDAO.Instance.GetDoanhthudathanhtoan().Rows)
            {
                data.Add(new CTdoanhthuDTO(item));
            }
            return data;
        }
        public List<CTdoanhthuDTO> Getdoanhthuchuaduocthanhtoan()
        {
            List<CTdoanhthuDTO> data = new List<CTdoanhthuDTO>();
            foreach (DataRow item in DoanhthuctDAO.Instance.GetDoanhthuchuathanhtoan().Rows)
            {
                data.Add(new CTdoanhthuDTO(item));
            }
            return data;
        }
    }
}
