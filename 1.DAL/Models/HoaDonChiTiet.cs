using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_Ban_Sach._1.DAL.Models
{
    public class HoaDonChiTiet
    {
        public Guid IDHoaDonChiTiet { get; set; }
        public string MaHDCT { get; set; }
        public Guid idSanPham { get; set; }
        public Guid idHoaDon { get; set; }
        public int SoLuong { get; set; }
        public double TongTien { get; set; }

        public virtual SanPham SanPham { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}
