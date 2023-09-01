
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
    public class HoaDonChiTietRepositories : IHoaDonChiTietRepositories
    {
        DbSach context;
        public HoaDonChiTietRepositories()
        {
            context = new DbSach();
        }
        public bool Add(HoaDonChiTiet hoaDonChiTiet)
        {
            if (hoaDonChiTiet == null)
            {
                return false;
            }
            context.hoaDonChiTiets.Add(hoaDonChiTiet);
            context.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet hoaDonChiTiet)
        {
            if (hoaDonChiTiet == null)
            {
                return false;
            }
            var obj = context.hoaDonChiTiets.FirstOrDefault(c => c.IDHoaDonChiTiet == hoaDonChiTiet.IDHoaDonChiTiet);
            context.hoaDonChiTiets.Remove(hoaDonChiTiet);
            context.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return context.hoaDonChiTiets.ToList();
        }

        public bool Update(HoaDonChiTiet hoaDonChiTiet)
        {
            if (hoaDonChiTiet == null)
            {
                return false;
            }
            var obj = context.hoaDonChiTiets.FirstOrDefault(c => c.IDHoaDonChiTiet == hoaDonChiTiet.IDHoaDonChiTiet);
            obj.IDHoaDonChiTiet = hoaDonChiTiet.IDHoaDonChiTiet;
            obj.MaHDCT = hoaDonChiTiet.MaHDCT;
            obj.SoLuong = hoaDonChiTiet.SoLuong;
            obj.TongTien = hoaDonChiTiet.TongTien;
            context.hoaDonChiTiets.Update(obj);
            context.SaveChanges();
            return true;
        }
    }
}
