
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
    public class NhaCungCapRepositories : INhaCungCapRepositories
    {
        DbSach context;
        public NhaCungCapRepositories()
        {
            context = new DbSach();
        }
        public bool Add(NhaCungCap nhaCungCap)
        {
            if (nhaCungCap == null)
            {
                return false;
            }
            context.nhaCungCaps.Add(nhaCungCap);
            context.SaveChanges();
            return true;
        }

        public bool Delete(NhaCungCap nhaCungCap)
        {
            if (nhaCungCap == null)
            {
                return false;
            }
            var obj = context.nhaCungCaps.FirstOrDefault(c => c.IDNhaCungCap == nhaCungCap.IDNhaCungCap);
            context.nhaCungCaps.Remove(nhaCungCap);
            context.SaveChanges();
            return true;
        }

        public List<NhaCungCap> GetAll()
        {
            return context.nhaCungCaps.ToList();
        }

        public bool Update(NhaCungCap nhaCungCap)
        {
            if (nhaCungCap == null)
            {
                return false;
            }
            var obj = context.nhaCungCaps.FirstOrDefault(c => c.IDNhaCungCap == nhaCungCap.IDNhaCungCap);
            obj.IDNhaCungCap = nhaCungCap.IDNhaCungCap;
            obj.MaNCC = nhaCungCap.MaNCC;
            obj.TenNhaCungCap = nhaCungCap.TenNhaCungCap;
            obj.SdtNCC = nhaCungCap.SdtNCC;
            obj.DiaCHi = nhaCungCap.DiaCHi;
            obj.trangThai = nhaCungCap.trangThai;
            context.nhaCungCaps.Update(obj);
            context.SaveChanges();
            return true;
        }
    }
}
