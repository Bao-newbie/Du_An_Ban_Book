using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonChiTietvIEW
    {
        public SanPham sanPham { get; set; }
        public HoaDon hoaDon { get; set; }
        public Guid idHoaDonCT { get; set; }
        public string MaHDCt { get; set; }
        public Guid idSanPham { get; set; }
        public Guid IdHoaDon { get; set; }
        public int soLuong { get; set; }
        public double tongTien { get; set; }

        public string tenSach { get; set; }
        public double giaBan { get; set; }
        public int soLuongTon { get; set; }
    }
}
