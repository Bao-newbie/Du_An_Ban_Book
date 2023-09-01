
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
    public class TacGiaRepositories : ITacGiaRepositories
    {
        DbSach context;

        public TacGiaRepositories()
        {
            context = new DbSach();
        }
        public bool Add(TacGia tacGia)
        {
            if (tacGia == null)
            {
                return false;
            }
            context.tacGias.Add(tacGia);
            context.SaveChanges();
            return true;
        }

        public bool Delete(TacGia tacGia)
        {
            if (tacGia == null)
            {
                return false;
            }
            var obj = context.tacGias.FirstOrDefault(c => c.idTacGia == tacGia.idTacGia);
            context.tacGias.Remove(tacGia);
            context.SaveChanges();
            return true;
        }

        public List<TacGia> GetAll()
        {
            return context.tacGias.ToList();
        }

        public bool Update(TacGia tacGia)
        {
            if (tacGia == null)
            {
                return false;
            }
            var obj = context.tacGias.FirstOrDefault(c => c.idTacGia == tacGia.idTacGia);
            obj.idTacGia = tacGia.idTacGia;
            obj.MaTG = tacGia.MaTG;
            obj.Ten = tacGia.Ten;
            obj.Tuoi = tacGia.Tuoi;
            obj.DiaChi = tacGia.DiaChi;
            obj.SDT = tacGia.SDT;
            obj.Email = tacGia.Email;
            context.tacGias.Update(obj);
            context.SaveChanges();
            return true;
        }
    }
}
