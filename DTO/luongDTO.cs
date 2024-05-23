using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class luongDTO
    {
        private string manv;
        private string tennv;
        private string chucvu;
        private string luong1ngay;
        private int songay;
        private int ngaynghi;
        private string phucap;
        private int diemchuyencan;
        private string luong;

        public luongDTO(string manv, string tennv, string chucvu, string luong1ngay, int songay, int ngaynghi, string phucap, int diemchuyencan, string luong)
        {
            this.Manv = manv;
            this.Tennv = tennv;
            this.Chucvu = chucvu;
            this.Luong1ngay = luong1ngay;
            this.Songay = songay;
            this.Ngaynghi = ngaynghi;
            this.Phucap = phucap;
            this.Diemchuyencan = diemchuyencan;
            this.Luong = luong;
        }
        CultureInfo culture = new CultureInfo("vi-Vn");
        public luongDTO(DataRow row)
        {
            this.Manv = row["maNV"].ToString();
            this.Tennv = row["tenNV"].ToString();
            this.Chucvu = row["chucvu"].ToString();
            this.Luong1ngay = Convert.ToInt32(row["luong1ngay"]).ToString("c",culture).Split(',')[0]+" VNĐ";
            this.Songay = (int)row["songay"];
            this.Ngaynghi = (int)row["ngaynghi"];
            this.Phucap = Convert.ToInt32(row["phucap"]).ToString("c",culture).Split(',')[0]+" VNĐ";
            this.Diemchuyencan = (int)row["diemchuyencan"];
            this.Luong = Convert.ToInt32(row["luong"]).ToString("c",culture).Split(',')[0]+" VNĐ";
        }
        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Luong1ngay { get => luong1ngay; set => luong1ngay = value; }
        public int Songay { get => songay; set => songay = value; }
        public int Ngaynghi { get => ngaynghi; set => ngaynghi = value; }
        public string Phucap { get => phucap; set => phucap = value; }
        public int Diemchuyencan { get => diemchuyencan; set => diemchuyencan = value; }
        public string Luong { get => luong; set => luong = value; }
    }
}
