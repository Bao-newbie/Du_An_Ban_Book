using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class Sach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hinhThucBias",
                columns: table => new
                {
                    idBia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaBia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiBia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hinhThucBias", x => x.idBia);
                });

            migrationBuilder.CreateTable(
                name: "khachHangs",
                columns: table => new
                {
                    IDKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHangs", x => x.IDKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "nhaCungCaps",
                columns: table => new
                {
                    IDNhaCungCap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenNhaCungCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SdtNCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaCHi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhaCungCaps", x => x.IDNhaCungCap);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nXBs",
                columns: table => new
                {
                    IDNXB = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNXB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenNXB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nXBs", x => x.IDNXB);
                });

            migrationBuilder.CreateTable(
                name: "tacGias",
                columns: table => new
                {
                    idTacGia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaTG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tuoi = table.Column<int>(type: "int", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tacGias", x => x.idTacGia);
                });

            migrationBuilder.CreateTable(
                name: "theLoais",
                columns: table => new
                {
                    IDTheLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaTheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenTheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theLoais", x => x.IDTheLoai);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    IDHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.IDHoaDon);
                    table.ForeignKey(
                        name: "FK_hoaDons_khachHangs_idKhachHang",
                        column: x => x.idKhachHang,
                        principalTable: "khachHangs",
                        principalColumn: "IDKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDons_nhanViens_idNhanVien",
                        column: x => x.idNhanVien,
                        principalTable: "nhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    IDsanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenSach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    GiaNhap = table.Column<double>(type: "float", nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    Anh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdTacGia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idNXB = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idNhaCungCap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idTheLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idHinhThucBia = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.IDsanPham);
                    table.ForeignKey(
                        name: "FK_sanPhams_hinhThucBias_idHinhThucBia",
                        column: x => x.idHinhThucBia,
                        principalTable: "hinhThucBias",
                        principalColumn: "idBia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhams_nhaCungCaps_idNhaCungCap",
                        column: x => x.idNhaCungCap,
                        principalTable: "nhaCungCaps",
                        principalColumn: "IDNhaCungCap",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhams_nXBs_idNXB",
                        column: x => x.idNXB,
                        principalTable: "nXBs",
                        principalColumn: "IDNXB",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhams_tacGias_IdTacGia",
                        column: x => x.IdTacGia,
                        principalTable: "tacGias",
                        principalColumn: "idTacGia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhams_theLoais_idTheLoai",
                        column: x => x.idTheLoai,
                        principalTable: "theLoais",
                        principalColumn: "IDTheLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiets",
                columns: table => new
                {
                    IDHoaDonChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHDCT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiets", x => x.IDHoaDonChiTiet);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_hoaDons_idHoaDon",
                        column: x => x.idHoaDon,
                        principalTable: "hoaDons",
                        principalColumn: "IDHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_sanPhams_idSanPham",
                        column: x => x.idSanPham,
                        principalTable: "sanPhams",
                        principalColumn: "IDsanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_idHoaDon",
                table: "hoaDonChiTiets",
                column: "idHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_idSanPham",
                table: "hoaDonChiTiets",
                column: "idSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_idKhachHang",
                table: "hoaDons",
                column: "idKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_idNhanVien",
                table: "hoaDons",
                column: "idNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_idHinhThucBia",
                table: "sanPhams",
                column: "idHinhThucBia");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_idNhaCungCap",
                table: "sanPhams",
                column: "idNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_idNXB",
                table: "sanPhams",
                column: "idNXB");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_IdTacGia",
                table: "sanPhams",
                column: "IdTacGia");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_idTheLoai",
                table: "sanPhams",
                column: "idTheLoai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "sanPhams");

            migrationBuilder.DropTable(
                name: "khachHangs");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "hinhThucBias");

            migrationBuilder.DropTable(
                name: "nhaCungCaps");

            migrationBuilder.DropTable(
                name: "nXBs");

            migrationBuilder.DropTable(
                name: "tacGias");

            migrationBuilder.DropTable(
                name: "theLoais");
        }
    }
}
