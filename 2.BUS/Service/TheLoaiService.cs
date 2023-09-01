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
    public class TheLoaiService : ITheLoaiService
    {
        ITheLoaiRepositories iTheLoaiRP;
        public TheLoaiService()
        {
            iTheLoaiRP = new TheLoaiRepositories();
        }
        public bool Add(TheLoaiView obj)
        {

            if (obj == null) return false;
            var ncc = new TheLoai()
            {
                IDTheLoai = Guid.NewGuid(),
                MaTheLoai = obj.MaTheLoai,
                TenTheLoai = obj.TenTheLoai,
                
            };
            if (iTheLoaiRP.Add(ncc)) return true;
            return false;
        }

        public bool Delete(TheLoaiView obj)
        {
            if (obj == null) return false;
            var nxb = iTheLoaiRP.GetAll().FirstOrDefault(c => c.MaTheLoai == obj.MaTheLoai);
            if (iTheLoaiRP.Delete(nxb)) return true;
            return false;
        }

        public List<TheLoaiView> GetAll()
        {
            List<TheLoaiView> lst = new List<TheLoaiView>();
            lst = (from a in iTheLoaiRP.GetAll()
                   select new TheLoaiView
                   {
                       idTheLoai = a.IDTheLoai,
                       MaTheLoai = a.MaTheLoai,
                       TenTheLoai = a.TenTheLoai,
                       
                   }).ToList();
            return lst;
        }

        public bool Update(TheLoaiView obj)
        {
            if (obj == null) return false;
            var abc = iTheLoaiRP.GetAll().FirstOrDefault(c => c.IDTheLoai == obj.idTheLoai);
            abc.MaTheLoai = obj.MaTheLoai;
            abc.TenTheLoai = obj.TenTheLoai;
           
            if (iTheLoaiRP.Update(abc)) return true;
            return false;
        }
    }
}
