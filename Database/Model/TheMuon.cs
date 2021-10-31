using System;

namespace Database.Model
{
    public class TheMuon
    {
        public int sMaThe { get; set; }
        public int sMaDocGia { get; set; }
        public DocGia sDocGia { get; set; }
        public int sMaSach { get; set; }
        public Sach sSach { get; set; }
        public DateTime dNgayMuon { get; set; }
        public DateTime dNgayTra { get; set; }
        public int sMaNhanVien { get; set; }
        public ThuThu sNhanVien { get; set; }
        public double fGiaThue { get; set; }
    }
}
