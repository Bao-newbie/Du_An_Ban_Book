
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
    public class SanPhamRepositories : ISanPhamRepositories
    {
        DbSach context;
        public SanPhamRepositories()
        {
            context = new DbSach();
        }
        public bool Add(SanPham sanPham)
        {
            if (sanPham == null)
            {
                return false;
            }
            context.sanPhams.Add(sanPham);
            context.SaveChanges();
            return true;
        }

        public bool Delete(SanPham sanPham)
        {
            if (sanPham == null)
            {
                return false;
            }
            var obj = context.sanPhams.FirstOrDefault(c => c.IDsanPham == sanPham.IDsanPham);
            context.sanPhams.Remove(sanPham);
            context.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return context.sanPhams.ToList();
        }

        public bool Update(SanPham sanPham)
        {
            if (sanPham == null)
            {
                return false;
            }
            var obj = context.sanPhams.FirstOrDefault(c => c.IDsanPham == sanPham.IDsanPham);
            obj.IDsanPham = sanPham.IDsanPham;
            obj.MaSach = sanPham.MaSach;
            obj.TenSach = sanPham.TenSach;
            obj.SoLuongTon = sanPham.SoLuongTon;
            obj.GiaNhap = sanPham.GiaNhap;
            obj.GiaBan = sanPham.GiaBan;
            obj.Anh = sanPham.Anh;
            obj.TrangThai = sanPham.TrangThai;
            context.sanPhams.Update(obj);
            context.SaveChanges();
            return true;
        }
    }
}
