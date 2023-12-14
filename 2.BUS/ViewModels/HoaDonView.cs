using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonView
    {
        //public Guid iDnhanVien { get; set; }
        public Guid iDkhachHang { get; set; }
        public Guid iDhoaDon { get; set; }
        public string MaHD { get; set; }
        //public string TenNV { get; set; }
        public DateTime ngayThanhToan { get; set; }
        public int trangThai { get; set; }
        public string maKH { get; set; }
        public string tenKH { get; set; }
        public KhachHang khachHang { get; set; }
        public HoaDonChiTiet HoaDonChiTiet { get; set; }
    }
}
