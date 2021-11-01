using Database.Enum;
using System;

namespace Database.Model
{
    public class YeuCauSach
    {
        public int sMaYeuCau { get; set; }
        public int sMaDocGia { get; set; }
        public DocGia sDocGia { get; set; }
        public int sMaSach { get; set; }
        public Sach sSach { get; set; }
        public DateTime dNgayMuon { get; set; }
        public DateTime dNgayTra { get; set; }
        public TrangThai sTrangThai { get; set; }
        public double fGiaThue { get; set; }
    }
}
