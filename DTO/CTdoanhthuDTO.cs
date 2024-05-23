using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTdoanhthuDTO
    {
        private int id;
        private string ngayvao;
        private string ngayra;
        private int idban;
        private string tendanhmuc;
        private string tenmon;
        private int soluong;
        private string giamgia;
        private string tongtien;
        private string trangthai;

        public CTdoanhthuDTO(int id, string ngayvao, string ngayra, int idban, string tendanhmuc, string tenmon, int soluong, string giamgia, string tongtien, string trangthai)
        {
            this.Id = id;
            this.Ngayvao = ngayvao;
            this.Ngayra = ngayra;
            this.Idban = idban;
            this.Tendanhmuc = tendanhmuc;
            this.Tenmon = tenmon;
            this.Soluong = soluong;
            this.Giamgia = giamgia;
            this.Tongtien = tongtien;
            this.Trangthai = trangthai;
        }
        CultureInfo culture = new CultureInfo("vi-Vn");
        public CTdoanhthuDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Ngayvao = Convert.ToDateTime(row["ngayvao"]).ToString("dd-MM-yyyy");
            this.ngayra=(row["ngayra"]==DBNull.Value)?"Trống": Convert.ToDateTime(row["ngayra"]).ToString("dd-MM-yyyy");
            this.Idban = (int)row["idban"];
            this.Tendanhmuc = row["tendanhmuc"].ToString();
            this.Tenmon = row["tenmon"].ToString();
            this.Soluong = (int)row["soluong"];
            this.Giamgia = row["giamgia"].ToString()+" %";
            this.Tongtien = Convert.ToInt32(row["tongtien"]).ToString("c",culture).Split(',')[0]+" VNĐ";
            this.Trangthai = ((int)row["trangthai"]==1)? "Đã thanh toán":"Chưa thanh toán";
        }
        public int Id { get => id; set => id = value; }
        public string Ngayvao { get => ngayvao; set => ngayvao = value; }
        public string Ngayra { get => ngayra; set => ngayra = value; }
        public int Idban { get => idban; set => idban = value; }
        public string Tendanhmuc { get => tendanhmuc; set => tendanhmuc = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Giamgia { get => giamgia; set => giamgia = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
