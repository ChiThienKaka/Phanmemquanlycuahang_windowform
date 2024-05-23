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
    public class GetmondachonBUS
    {
        private static GetmondachonBUS instance;

        public static GetmondachonBUS Instance { get { if (instance == null) instance = new GetmondachonBUS();return GetmondachonBUS.instance; } private set => instance = value; }
        private GetmondachonBUS() { }
        public List<GetDsthemonDTO> Getdsthemmon()
        {
            List<GetDsthemonDTO> dstm = new List<GetDsthemonDTO>();
            foreach (DataRow item in MondachonDAO.Instance.Getmondachon().Rows)
            {
                GetDsthemonDTO mondachon = new GetDsthemonDTO(item);
                dstm.Add(mondachon);
            }
            return dstm;
        }
    }
}
