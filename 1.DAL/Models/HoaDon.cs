using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_Ban_Sach._1.DAL.Models
{
    public class HoaDon
    {
        public Guid IDHoaDon { get; set; }
        public string MaHD { get; set; }
        public Guid idKhachHang { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public int TrangThai { get; set; }

        public virtual KhachHang KhachHang { get; set;}
        public virtual List<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
