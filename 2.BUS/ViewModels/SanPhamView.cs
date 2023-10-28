using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class SanPhamView
    {
        //public NXB nXB { get; set; }
        //public NhaCungCap nhaCungCap { get; set; }
        //public TheLoai theLoai { get; set; }
        //public HinhThucBia hinhThucBia { get; set; }
        //public TacGia TacGia { get; set; }
        public Guid IDsanPham { get; set; }
        public Guid idTacGia { get; set; }
        public Guid idNXB { get; set; }
        public Guid idNhaCungCap { get; set; }
        public Guid idTheLoai { get; set; }
        public Guid idHinhThucBia { get; set; }
        public string MaSP { get; set; }
        public string TenSach { get; set; }
        public int SoLuongTon { get; set; }
        public double GiaNhap { get; set; }
        public double GiaBan { get; set; }     
        public string Anh { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
        public string TenTG { get; set; }
        public string TenNXB { get; set; }
        public string TenNCC { get; set; }
        public string TenTheLoai { get; set; }
        public string LoaiBia { get; set; }
    }
}
