using Database.Enum;
using System;
using System.Collections.Generic;

namespace Database.Model
{
    public class Sach
    {
        public int sMaSach { get; set; }
        public string sTenSach { get; set; }
        public TheLoai sTheLoai { get; set; }
        public string sTacGia { get; set; }
        public string sNhaXuatBan { get; set; }
        public int iNamXuatBan { get; set; }
        public DateTime dNgayNhap { get; set; }
        public TinhTrang sTinhTrang { get; set; }
        public IList<TheMuon> TheMuons { get; set; }
    }
}
