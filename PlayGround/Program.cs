using Database;
using Database.Enum;
using Database.Model;
using System;
using System.Collections.Generic;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            var sach1 = new Sach()
            {
                sTenSach = "Thieu Nu Thi Thang",
                sTheLoai = TheLoai.TruyenDoc,
                sTacGia = "Nguyen Du",
                sNhaXuatBan = "Kim Dong",
                iNamXuatBan = 1995,
                dNgayNhap = new DateTime(1995, 1, 3),
                sTinhTrang = TinhTrang.DaMuon,
            };

            var sach2 = new Sach()
            {
                sTenSach = "Thep da toi the day",
                sTheLoai = TheLoai.TruyenDoc,
                sTacGia = "Nikolai Ostrovsky",
                sNhaXuatBan = "Amzon",
                iNamXuatBan = 1945,
                dNgayNhap = new DateTime(1990, 3, 4),
                sTinhTrang = TinhTrang.DaMuon,
            };

            var sach3 = new Sach()
            {
                sTenSach = "Thuy Thu Mat Trang",
                sTheLoai = TheLoai.TruyenTranh,
                sTacGia = "Natsumi",
                sNhaXuatBan = "Okeda",
                iNamXuatBan = 1988,
                dNgayNhap = new DateTime(2000, 2, 23),
                sTinhTrang = TinhTrang.DaMuon,
            };

            var sach4 = new Sach()
            {
                sTenSach = "Rung Nauy",
                sTheLoai = TheLoai.TruyenDoc,
                sTacGia = "Misaki",
                sNhaXuatBan = "Okeda",
                iNamXuatBan = 1977,
                dNgayNhap = new DateTime(2010, 10, 31),
                sTinhTrang = TinhTrang.DaMuon,
            };

            var sach5 = new Sach()
            {
                sTenSach = "Oi que toi",
                sTheLoai = TheLoai.TruyenDoc,
                sTacGia = "Tung Duong",
                sNhaXuatBan = "Nhan Dan",
                iNamXuatBan = 2010,
                dNgayNhap = new DateTime(2015, 9, 12),
                sTinhTrang = TinhTrang.TrongKho,
            };

            var sach6 = new Sach()
            {
                sTenSach = "Than Dong Dat Viet",
                sTheLoai = TheLoai.TruyenTranh,
                sTacGia = "TLinh",
                sNhaXuatBan = "Kim Dong",
                iNamXuatBan = 2007,
                dNgayNhap = new DateTime(2018, 4, 18),
                sTinhTrang = TinhTrang.TrongKho,
            };

            var nhanVien1 = new ThuThu()
            {
                sTenNhanVien = "Nhan Vien 1",
                sGioiTinh = GioiTinh.Nu,
                sQueQuan = "Hai Phong",
                iTuoi = 24,
                cChucVu = ChucVu.NhanVien,
                sUser = "Nhan Vien 1",
                sPassword = "password",
            };

            var nhanVien2 = new ThuThu()
            {
                sTenNhanVien = "Nhan Vien 2",
                sGioiTinh = GioiTinh.Nam,
                sQueQuan = "Ninh Binh",
                iTuoi = 25,
                cChucVu = ChucVu.NhanVien,
                sUser = "Nhan Vien 2",
                sPassword = "password",
            };

            var nhanVien3 = new ThuThu()
            {
                sTenNhanVien = "Admin",
                sGioiTinh = GioiTinh.Nam,
                sQueQuan = "Hai Phong",
                iTuoi = 24,
                cChucVu = ChucVu.Admin,
                sUser = "Admin",
                sPassword = "password",
            };

            using ThuVienDbContext myContext = new ThuVienDbContext();
            myContext.DocGias.AddRange( new List<DocGia>()
            {
                new DocGia()
                {
                    sTenDocGia = "Doc Gia A",
                    sGioiTinh = GioiTinh.Nam,
                    sQueQuan = "Thai Binh",
                    sDiaChi = "14 Ngo 28",
                    sNgaySinh = new DateTime(1990, 6, 10),
                    dNgayLapThe = new DateTime(2020, 6, 10),
                    sNgayHetHan = new DateTime(2025, 6, 10),
                    sUser = "Doc Gia A",
                    sPassword = "password",
                    TheMuons = new List<TheMuon>()
                    {
                        new TheMuon()
                        {
                            sSach = sach1,
                            sNhanVien = nhanVien1,
                            dNgayMuon = new DateTime(2020, 3, 10),
                            dNgayTra = new DateTime(2021, 5, 20),
                            fGiaThue = 19000,

                        },
                        new TheMuon()
                        {
                            sSach = sach2,
                            sNhanVien = nhanVien2,
                            dNgayMuon = new DateTime(2020, 5, 10),
                            dNgayTra = new DateTime(2021, 2, 20),
                            fGiaThue = 19000,

                        }
                    }
                },
                new DocGia()
                {
                    sTenDocGia = "Doc Gia B",
                    sGioiTinh = GioiTinh.Nu,
                    sQueQuan = "Nam Dinh",
                    sDiaChi = "32 Cho Sat",
                    sNgaySinh = new DateTime(1986, 1, 2),
                    dNgayLapThe = new DateTime(2017, 4, 12),
                    sNgayHetHan = new DateTime(2025, 5, 11),
                    sUser = "Doc Gia B",
                    sPassword = "password",
                    TheMuons = new List<TheMuon>()
                    {
                        new TheMuon()
                        {
                            sSach = sach4,
                            sNhanVien = nhanVien3,
                            dNgayMuon = new DateTime(2020, 3, 1),
                            dNgayTra = new DateTime(2021, 12, 2),
                            fGiaThue = 19000,

                        }
                    }
                },
                new DocGia()
                {
                    sTenDocGia = "Doc Gia C",
                    sGioiTinh = GioiTinh.Nu,
                    sQueQuan = "Dien Bien",
                    sDiaChi = "32 Phan Chau Trinh",
                    sNgaySinh = new DateTime(1987, 6, 10),
                    dNgayLapThe = new DateTime(2012, 3, 23),
                    sNgayHetHan = new DateTime(2022, 6, 12),
                    sUser = "Doc Gia B",
                    sPassword = "password",
                    TheMuons = new List<TheMuon>()
                    {
                        new TheMuon()
                        {
                            sSach = sach3,
                            sNhanVien = nhanVien1,
                            dNgayMuon = new DateTime(2021, 9, 10),
                            dNgayTra = new DateTime(2021, 8, 12),
                            fGiaThue = 19000,

                        }
                    }
                }
            }
            );

            myContext.Sachs.AddRange(new List<Sach> { sach5, sach6 });
            myContext.SaveChanges();
        }
    }
}
