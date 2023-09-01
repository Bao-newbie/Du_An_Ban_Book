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
    public class KhachHangService : IKhachHangService
    {
        IKhachHangRepositories iRp;
        public KhachHangService()
        {
            iRp = new KhachHangRepositories();
        }
        public bool Add(KhachHangView obj)
        {
            if (obj == null) return false;
            var ncc = new KhachHang()
            {
                IDKhachHang = Guid.NewGuid(),
                MaKH = obj.MaKh,
                Ten = obj.Ten,
                DiaChi = obj.DiaChi,
               
                SDT = obj.sdt
            };
            if (iRp.Add(ncc)) return true;
            return false;
        }

        public bool Delete(KhachHangView obj)
        {
            if (obj == null) return false;
            var ncc = iRp.GetAll().FirstOrDefault(c => c.IDKhachHang == obj.IdKhachHang);
            if (iRp.Delete(ncc)) return true;
            return false;
        }

        public List<KhachHangView> GetAll()
        {
            List<KhachHangView> lst = new List<KhachHangView>();
            lst = (from a in iRp.GetAll()
                   select new KhachHangView
                   {
                       IdKhachHang = a.IDKhachHang,
                       MaKh = a.MaKH,                    
                       Ten = a.Ten,
                       DiaChi = a.DiaChi,                     
                       sdt = a.SDT,
                   }).ToList();
            return lst;
        }

        public bool Update(KhachHangView obj)
        {
            if (obj == null) return false;
            var ncc = iRp.GetAll().FirstOrDefault(c => c.IDKhachHang == obj.IdKhachHang);
            ncc.MaKH = obj.MaKh;
            ncc.Ten = obj.Ten;
            ncc.DiaChi = obj.DiaChi;
            ncc.SDT = obj.sdt;
            if (iRp.Update(ncc)) return true;
            return false;
        }
    }
}
