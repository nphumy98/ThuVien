using Database;
using Database.Enum;
using Database.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ThuVien.Helpers
{
    public static class CongCu
    {
        public static UserType LoaiUser = UserType.DocGia;
        public static ThuVienDbContext myContext = new ThuVienDbContext();
        public static DocGia CurrentDocGia;
        public static ThuThu CurrentNhanVien;
        public static ThuThu CurrentAdmin;
        public static Sach CurrentSach;
        public static YeuCauSach CurrentYeuCauSach;
        public static TheMuon CurrentTheMuon;

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public static void SeedData()
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
                sDiaChi = "20 Phan Thanh Gian",
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
                sDiaChi = "15 Tran Phu",
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
                sDiaChi = "30 Le Hong Phong",
                iTuoi = 24,
                cChucVu = ChucVu.Admin,
                sUser = "Admin",
                sPassword = "password",
            };


            // Doc gia ==============================================================================
            var docgia1 = new DocGia()
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
            };

            var docgia2 = new DocGia()
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
            };

            var docgia3 = new DocGia()
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
            };


            // Yeu cau sach ==========================================
            var yeuCauSach1 = new YeuCauSach()
            {
                sDocGia = docgia1,
                sSach = sach5,
                dNgayMuon = new DateTime(2021, 12, 1),
                dNgayTra = new DateTime(2021, 12, 28),
                sTrangThai = TrangThai.ChoQuyetDinh,
                fGiaThue = 25000

            };

            var yeuCauSach2 = new YeuCauSach()
            {
                sDocGia = docgia1,
                sSach = sach6,
                dNgayMuon = new DateTime(2021, 12, 13),
                dNgayTra = new DateTime(2021, 12, 25),
                sTrangThai = TrangThai.ChoQuyetDinh,
                fGiaThue = 30000
            };

            var yeuCauSach3 = new YeuCauSach()
            {
                sDocGia = docgia2,
                sSach = sach1,
                dNgayMuon = new DateTime(2021, 11, 3),
                dNgayTra = new DateTime(2021, 12, 1),
                sTrangThai = TrangThai.ChoQuyetDinh,
                fGiaThue = 16000
            };

            var yeuCauSach4 = new YeuCauSach()
            {
                sDocGia = docgia2,
                sSach = sach6,
                dNgayMuon = new DateTime(2021, 11, 23),
                dNgayTra = new DateTime(2021, 12, 15),
                sTrangThai = TrangThai.ChoQuyetDinh,
                fGiaThue = 27000
            };

            var yeuCauSach5 = new YeuCauSach()
            {
                sDocGia = docgia3,
                sSach = sach2,
                dNgayMuon = new DateTime(2021, 11, 4),
                dNgayTra = new DateTime(2021, 11, 20),
                sTrangThai = TrangThai.ChoQuyetDinh,
                fGiaThue = 17000
            };

            var yeuCauSach6 = new YeuCauSach()
            {
                sDocGia = docgia3,
                sSach = sach5,
                dNgayMuon = new DateTime(2021, 11, 11),
                dNgayTra = new DateTime(2021, 12, 6),
                sTrangThai = TrangThai.ChoQuyetDinh,
                fGiaThue = 22000
            };

            var yeuCauSach7 = new YeuCauSach()
            {
                sDocGia = docgia3,
                sSach = sach6,
                dNgayMuon = new DateTime(2021, 11, 7),
                dNgayTra = new DateTime(2021, 12, 4),
                sTrangThai = TrangThai.ChoQuyetDinh,
                fGiaThue = 18500
            };

            myContext = new ThuVienDbContext();
            if (!myContext.DocGias.ToList().Any())
            {
                myContext.DocGias.AddRange(new List<DocGia> { docgia1, docgia2, docgia3 });
                myContext.YeuCauSachs.AddRange(new List<YeuCauSach> { yeuCauSach1, yeuCauSach2, yeuCauSach3, yeuCauSach4, yeuCauSach5, yeuCauSach6, yeuCauSach7 });
                myContext.Sachs.AddRange(new List<Sach> { sach5, sach6 });
                myContext.SaveChanges();
            }
        }
    }
}

