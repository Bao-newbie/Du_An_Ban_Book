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
    public class NXBService : INXBService
    {
        INXBRepositories iNxbRp;
        public NXBService()
        {
            iNxbRp = new NXBRepositories();
        }

        public List<NXBView> GetAll()
        {
            List<NXBView> lst = new List<NXBView>();
            lst = (from a in iNxbRp.GetAll()
                   select new NXBView()
                   {
                       idNXB = a.IDNXB,
                       MaNXB = a.MaNXB,
                       TenNXB = a.TenNXB,
                       SDT = a.SDT,
                       diaChi = a.DiaChi,

                   }).ToList();
            return lst;
        }
        public NXB GetByName(string ten)
        {
            return iNxbRp.GetAll().FirstOrDefault(c => c.TenNXB == ten);
        }
        public bool Add(NXBView obj)
        {
            if (obj == null) return false;
            var nxb = new NXB()
            {
                IDNXB = Guid.NewGuid(),
                MaNXB = obj.MaNXB,
                TenNXB = obj.TenNXB,
                SDT = obj.SDT,
                DiaChi = obj.diaChi,

            };
            if (iNxbRp.Add(nxb)) return true;
            return false;
        }

        public bool Delete(NXBView obj)
        {
            if (obj == null) return false;
            var nxb = iNxbRp.GetAll().FirstOrDefault(c => c.TenNXB == obj.TenNXB);
            if (iNxbRp.Delete(nxb)) return true;
            return false;
        }

        public bool Update(NXBView obj)
        {
            if (obj == null) return false;
            var nxb = iNxbRp.GetAll().FirstOrDefault(c => c.IDNXB == obj.idNXB);
            nxb.MaNXB = obj.MaNXB;
            nxb.TenNXB = obj.TenNXB;
            nxb.SDT = obj.SDT;
            nxb.DiaChi = obj.diaChi;
            if (iNxbRp.Update(nxb)) return true;
            return false;
        }
    }
}
