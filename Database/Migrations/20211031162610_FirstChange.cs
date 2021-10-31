using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class FirstChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cChucVu",
                table: "ThuThus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cChucVu",
                table: "ThuThus");
        }
    }
}
