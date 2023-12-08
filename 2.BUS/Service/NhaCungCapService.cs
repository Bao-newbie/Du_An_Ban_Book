using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;
using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Service
{
    public class NhaCungCapService : INhaCungCapService
    {
        INhaCungCapRepositories iNhaCungCap;
        public NhaCungCapService()
        {
            iNhaCungCap = new NhaCungCapRepositories();
        }

        public bool Add(NhaCungCapView obj)
        {
            if(obj == null) return false;
            var ncc = new NhaCungCap()
            {
                IDNhaCungCap = Guid.NewGuid(),
                MaNCC = obj.MaNhaCungCap,
                TenNhaCungCap = obj.TenNCC,
                SdtNCC = obj.SDT,
                DiaCHi = obj.diaChi,
                trangThai = obj.trangThai,
                
            };
            if (iNhaCungCap.Add(ncc)) return true;
            return false;
        }

        public bool Delete(NhaCungCapView obj)
        {
            if(obj == null) return false;
            var ncc = iNhaCungCap.GetAll().FirstOrDefault(c=>c.IDNhaCungCap == obj.idNhaCC);
            if(iNhaCungCap.Delete(ncc)) return true;
            return false;
        }

        public List<NhaCungCapView> GetAll()
        {
            List<NhaCungCapView> lst = new List<NhaCungCapView> ();
            lst = (from a in iNhaCungCap.GetAll()
                   select new NhaCungCapView
                   {
                       idNhaCC = a.IDNhaCungCap,
                       MaNhaCungCap = a.MaNCC,
                       TenNCC = a.TenNhaCungCap,
                       SDT = a.SdtNCC,
                       diaChi = a.DiaCHi,
                       trangThai = a.trangThai,
                   }).ToList();
            return lst;
        }

        public bool Update(NhaCungCapView obj)
        {
            if (obj == null) return false;
            var ncc = iNhaCungCap.GetAll().FirstOrDefault(c => c.IDNhaCungCap == obj.idNhaCC);
            ncc.MaNCC = obj.MaNhaCungCap;
            ncc.TenNhaCungCap = obj.TenNCC;
            ncc.SdtNCC = obj.SDT;
            ncc.DiaCHi = obj.diaChi;
            ncc.trangThai = obj.trangThai;
            if(iNhaCungCap.Update(ncc) ) return true;
            return false;
        }
    }
}
