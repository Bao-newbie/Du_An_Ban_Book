
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
    public class KhachHangRepositories : IKhachHangRepositories
    {
        DbSach context;
        public KhachHangRepositories()
        {
            context = new DbSach();
        }
        public bool Add(KhachHang khachHang)
        {
            if (khachHang == null)
            {
                return false;
            }
            context.khachHangs.Add(khachHang);
            context.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang khachHang)
        {
            if (khachHang == null)
            {
                return false;
            }
            var obj = context.khachHangs.FirstOrDefault(c => c.IDKhachHang == khachHang.IDKhachHang);
            context.khachHangs.Remove(khachHang);
            context.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return context.khachHangs.ToList();
        }

        public bool Update(KhachHang khachHang)
        {
            if (khachHang == null)
            {
                return false;
            }
            var obj = context.khachHangs.FirstOrDefault(c => c.IDKhachHang == khachHang.IDKhachHang);
            obj.IDKhachHang = khachHang.IDKhachHang;
            obj.MaKH = khachHang.MaKH;
            obj.Ten = khachHang.Ten;
            obj.DiaChi = khachHang.DiaChi;
            obj.SDT = khachHang.SDT;
            context.khachHangs.Update(obj);
            context.SaveChanges();
            return true;
        }
    }
}
