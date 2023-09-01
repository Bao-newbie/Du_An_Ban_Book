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
    public class TacGiaService : ITacGiaService
    {
        ITacGiaRepositories iRp;
        public TacGiaService()
        {
            iRp = new TacGiaRepositories();
        }
        public bool Add(TacGiaView obj)
        {
            if (obj == null) return false;
            var ncc = new TacGia()
            {
                idTacGia = Guid.NewGuid(),
                MaTG = obj.MaTG,
                Ten = obj.Ten,
                Tuoi = obj.Tuoi,
                DiaChi = obj.diaChi,
                Email = obj.Email,
                SDT = obj.SDT,
            };
            if (iRp.Add(ncc)) return true;
            return false;
        }

        public bool Delete(TacGiaView obj)
        {
            if (obj == null) return false;
            var ncc = iRp.GetAll().FirstOrDefault(c => c.idTacGia == obj.idtacGia);
            if (iRp.Delete(ncc)) return true;
            return false;
        }

        public List<TacGiaView> GetAll()
        {
            List<TacGiaView> lst = new List<TacGiaView>();
            lst = (from a in iRp.GetAll()
                   select new TacGiaView
                   {
                       idtacGia = a.idTacGia,
                       MaTG = a.MaTG,
                       Ten = a.Ten,
                       Tuoi = a.Tuoi,
                       diaChi = a.DiaChi,
                       Email = a.Email,
                       SDT = a.SDT,
                   }).ToList();
            return lst;
        }

        public bool Update(TacGiaView obj)
        {
            if (obj == null) return false;
            var ncc = iRp.GetAll().FirstOrDefault(c => c.idTacGia == obj.idtacGia);
            ncc.MaTG = obj.MaTG;
            ncc.Ten = obj.Ten;
            ncc.Tuoi = obj.Tuoi;
            ncc.DiaChi = obj.diaChi;
            ncc.Email = obj.Email;
            ncc.SDT = obj.SDT;
            if (iRp.Update(ncc)) return true;
            return false;
        }
    }
}
