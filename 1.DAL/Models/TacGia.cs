using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_Ban_Sach._1.DAL.Models
{
    public class TacGia
    {
        public Guid idTacGia { get; set; }
        public string MaTG { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public int trangThai { get; set; }
        public virtual List<SanPham> SanPhams { get; set; }

    }
}
