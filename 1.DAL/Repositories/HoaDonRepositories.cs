
using _1.DAL.IRepositories;
using _1.DAL.SachDbContext;
using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonRepositories : IHoaDonRepositories
    {
        DbSach context;
        public HoaDonRepositories()
        {
            context = new DbSach();
        }
        public bool Add(HoaDon hoaDon)
        {
            if (hoaDon == null)
            {
                return false;
            }
            context.hoaDons.Add(hoaDon);
            context.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon hoaDon)
        {
            if (hoaDon == null)
            {
                return false;
            }
            var obj = context.hoaDons.FirstOrDefault(c => c.IDHoaDon== hoaDon.IDHoaDon);
            context.hoaDons.Remove(hoaDon);
            context.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return context.hoaDons.ToList();
        }

        public bool Update(HoaDon hoaDon)
        {
            if (hoaDon == null)
            {
                return false;
            }
            var obj = context.hoaDons.FirstOrDefault(c => c.IDHoaDon == hoaDon.IDHoaDon);
            obj.IDHoaDon = hoaDon.IDHoaDon;
            obj.MaHD = hoaDon.MaHD;
            obj.NgayThanhToan = hoaDon.NgayThanhToan;
            obj.TrangThai = hoaDon.TrangThai;
            context.hoaDons.Update(obj);
            context.SaveChanges();
            return true;
        }
    }
}
