using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_Ban_Sach._1.DAL.Models
{
    public class NXB
    {
        public Guid IDNXB { get; set; }
        public string MaNXB { get; set; }
        public string TenNXB { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public int trangThai { get; set; }

        public virtual List<SanPham> SanPhams { get; set; }
    }
}
