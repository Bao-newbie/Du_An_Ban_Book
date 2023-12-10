using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.SachDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NhanVienRepositories : INhanVienRepositories
    {
        DbSach context;
        public NhanVienRepositories()
        {
            context = new DbSach();
        }
        public bool Add(NhanVien nhanVien)
        {
            if (nhanVien == null)
            {
                return false;
            }
            context.nhanViens.Add(nhanVien);
            context.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return context.nhanViens.ToList();
        }

        public bool Update(NhanVien nhanVien)
        {
            if (nhanVien == null)
            {
                return false;
            }
            var obj = context.nhanViens.FirstOrDefault(x => x.Id == nhanVien.Id);
            obj.Id=nhanVien.Id;
            obj.MaNV=nhanVien.MaNV;
            obj.HoTen= nhanVien.HoTen;
            obj.Email= nhanVien.Email;
            obj.SDT= nhanVien.SDT;
            obj.DiaChi = nhanVien.DiaChi;
            obj.ChucVu= nhanVien.ChucVu;
            obj.TrangThai= nhanVien.TrangThai;
            obj.Password= nhanVien.Password;
            context.nhanViens.Update(nhanVien);
            context.SaveChanges();
            return true;
        }
    }
}
