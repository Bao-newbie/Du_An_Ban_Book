using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_Ban_Sach._1.DAL.Models
{
    public class SanPham
    {
        public Guid IDsanPham { get; set; }
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int SoLuongTon { get; set; }
        public double GiaNhap { get; set; }
        public double GiaBan { get; set; }
        public string Anh { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
        public Guid IdTacGia { get; set; }
        public Guid idNXB { get; set; }
        public Guid idNhaCungCap { get; set; }
        public Guid idTheLoai { get; set; }
        public Guid idHinhThucBia { get; set; }


        public virtual List<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual NXB NXB { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual HinhThucBia HinhThucBia { get; set; }
        public virtual TheLoai TheLoai { get; set; }
        public virtual TacGia TacGia { get; set; }


    }
}
