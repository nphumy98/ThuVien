using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocGias",
                columns: table => new
                {
                    sMaDocGia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sTenDocGia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sGioiTinh = table.Column<int>(type: "int", nullable: false),
                    sQueQuan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sDiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sNgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dNgayLapThe = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sNgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocGias", x => x.sMaDocGia);
                });

            migrationBuilder.CreateTable(
                name: "Sachs",
                columns: table => new
                {
                    sMaSach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sTenSach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sTheLoai = table.Column<int>(type: "int", nullable: false),
                    sTacGia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sNhaXuatBan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iNamXuatBan = table.Column<int>(type: "int", nullable: false),
                    dNgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sTinhTrang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sachs", x => x.sMaSach);
                });

            migrationBuilder.CreateTable(
                name: "ThuThus",
                columns: table => new
                {
                    sMaNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sTenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sGioiTinh = table.Column<int>(type: "int", nullable: false),
                    sQueQuan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iTuoi = table.Column<int>(type: "int", nullable: false),
                    sDiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sSDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dNgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cChucVu = table.Column<int>(type: "int", nullable: false),
                    sUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuThus", x => x.sMaNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "YeuCauSachs",
                columns: table => new
                {
                    sMaYeuCau = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sMaDocGia = table.Column<int>(type: "int", nullable: false),
                    sMaSach = table.Column<int>(type: "int", nullable: false),
                    dNgayMuon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dNgayTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sTrangThai = table.Column<int>(type: "int", nullable: false),
                    fGiaThue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YeuCauSachs", x => x.sMaYeuCau);
                    table.ForeignKey(
                        name: "FK_YeuCauSachs_DocGias_sMaDocGia",
                        column: x => x.sMaDocGia,
                        principalTable: "DocGias",
                        principalColumn: "sMaDocGia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YeuCauSachs_Sachs_sMaSach",
                        column: x => x.sMaSach,
                        principalTable: "Sachs",
                        principalColumn: "sMaSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TheMuons",
                columns: table => new
                {
                    sMaThe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sMaDocGia = table.Column<int>(type: "int", nullable: false),
                    sMaSach = table.Column<int>(type: "int", nullable: false),
                    dNgayMuon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dNgayTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sMaNhanVien = table.Column<int>(type: "int", nullable: false),
                    fGiaThue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheMuons", x => x.sMaThe);
                    table.ForeignKey(
                        name: "FK_TheMuons_DocGias_sMaDocGia",
                        column: x => x.sMaDocGia,
                        principalTable: "DocGias",
                        principalColumn: "sMaDocGia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TheMuons_Sachs_sMaSach",
                        column: x => x.sMaSach,
                        principalTable: "Sachs",
                        principalColumn: "sMaSach",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TheMuons_ThuThus_sMaNhanVien",
                        column: x => x.sMaNhanVien,
                        principalTable: "ThuThus",
                        principalColumn: "sMaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TheMuons_sMaDocGia",
                table: "TheMuons",
                column: "sMaDocGia");

            migrationBuilder.CreateIndex(
                name: "IX_TheMuons_sMaNhanVien",
                table: "TheMuons",
                column: "sMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_TheMuons_sMaSach",
                table: "TheMuons",
                column: "sMaSach");

            migrationBuilder.CreateIndex(
                name: "IX_YeuCauSachs_sMaDocGia",
                table: "YeuCauSachs",
                column: "sMaDocGia");

            migrationBuilder.CreateIndex(
                name: "IX_YeuCauSachs_sMaSach",
                table: "YeuCauSachs",
                column: "sMaSach");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TheMuons");

            migrationBuilder.DropTable(
                name: "YeuCauSachs");

            migrationBuilder.DropTable(
                name: "ThuThus");

            migrationBuilder.DropTable(
                name: "DocGias");

            migrationBuilder.DropTable(
                name: "Sachs");
        }
    }
}
