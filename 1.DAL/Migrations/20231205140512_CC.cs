using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class CC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "trangThai",
                table: "theLoais",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "trangThai",
                table: "tacGias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "trangThai",
                table: "nXBs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "trangThai",
                table: "nhaCungCaps",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "trangThai",
                table: "theLoais");

            migrationBuilder.DropColumn(
                name: "trangThai",
                table: "tacGias");

            migrationBuilder.DropColumn(
                name: "trangThai",
                table: "nXBs");

            migrationBuilder.DropColumn(
                name: "trangThai",
                table: "nhaCungCaps");
        }
    }
}
