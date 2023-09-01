using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_Ban_Sach._1.DAL.Models
{
    public class KhachHang
    {
        public Guid IDKhachHang { get; set; }
        public string MaKH { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }

        public virtual List<HoaDon> HoaDons { get; set; }
    }
}
