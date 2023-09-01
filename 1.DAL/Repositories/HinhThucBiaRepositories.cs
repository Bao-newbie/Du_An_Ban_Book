
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
    public class HinhThucBiaRepositories : IHinhThucBiaRepositories
    {
        DbSach context;
        public HinhThucBiaRepositories()
        {
            context = new DbSach();
        }
        public bool Add(HinhThucBia hinhThucBia)
        {
            if (hinhThucBia == null)
            {
                return false;
            }
            context.hinhThucBias.Add(hinhThucBia);
            context.SaveChanges();
            return true;
        }

        public bool Delete(HinhThucBia hinhThucBia)
        {
            if (hinhThucBia == null)
            {
                return false;
            }
            var obj = context.hinhThucBias.FirstOrDefault(c=>c.idBia == hinhThucBia.idBia);
            context.hinhThucBias.Remove(hinhThucBia);
            context.SaveChanges();
            return true;
        }

        public List<HinhThucBia> GetAll()
        {
            return context.hinhThucBias.ToList();
        }


        public bool Update(HinhThucBia hinhThucBia)
        {
            if (hinhThucBia == null)
            {
                return false;
            }
            var obj = context.hinhThucBias.FirstOrDefault(c => c.idBia == hinhThucBia.idBia);
            obj.idBia = hinhThucBia.idBia;
            obj.LoaiBia = hinhThucBia.LoaiBia;
            context.hinhThucBias.Update(obj);
            context.SaveChanges();
            return true;
        }
    }
}
