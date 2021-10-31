using Database.Enum;
using System;

namespace Database.Model
{
    public class DocGia
    {
        public int sMaDocGia { get; set; }
        public string sTenDocGia { get; set; }
        public GioiTinh sGioiTinh { get; set; }
        public string sQueQuan { get; set; }
        public string sDiaChi { get; set; }
        public DateTime sNgaySinh { get; set; }
        public DateTime dNgayLapThe { get; set; }
        public DateTime sNgayHetHan { get; set; }
        public string sUser { get; set; }
        public string sPassword { get; set; }

    }
}
