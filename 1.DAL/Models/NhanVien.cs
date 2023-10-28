using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class NhanVien
    {
        public Guid Id { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string ChucVu { get; set; }
        public int TrangThai { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<HoaDon> hoaDons { get; set; }
    }
}
