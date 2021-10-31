using Database.Enum;
using System;
using System.Collections.Generic;

namespace Database.Model
{
    public class ThuThu
    {
        public int sMaNhanVien { get; set; }
        public string sTenNhanVien { get; set; }
        public GioiTinh sGioiTinh { get; set; }
        public string sQueQuan { get; set; }
        public int iTuoi { get; set; }
        public string sDiaChi { get; set; }
        public string sSDT { get; set; }
        public DateTime dNgayVaoLam { get; set; }
        public ChucVu cChucVu { get; set; }
        public string sUser { get; set; }
        public string sPassword { get; set; }
        public IList<TheMuon> TheMuons { get; set; }
    }
}
