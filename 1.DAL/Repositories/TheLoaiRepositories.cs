
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
    public class TheLoaiRepositories : ITheLoaiRepositories
    {
        DbSach context;
        public TheLoaiRepositories()
        {
            context = new DbSach();
        }
        public bool Add(TheLoai theLoai)
        {
            if (theLoai == null)
            {
                return false;
            }
            context.theLoais.Add(theLoai);
            context.SaveChanges();
            return true;
        }

        public bool Delete(TheLoai theLoai)
        {
            if (theLoai == null)
            {
                return false;
            }
            var obj = context.theLoais.FirstOrDefault(c => c.IDTheLoai == theLoai.IDTheLoai);
            context.theLoais.Remove(theLoai);
            context.SaveChanges();
            return true;
        }

        public List<TheLoai> GetAll()
        {
            return context.theLoais.ToList();
        }

        public bool Update(TheLoai theLoai)
        {
            if (theLoai == null)
            {
                return false;
            }
            var obj = context.theLoais.FirstOrDefault(c => c.IDTheLoai == theLoai.IDTheLoai);
            obj.IDTheLoai = theLoai.IDTheLoai;
            obj.MaTheLoai = theLoai.MaTheLoai;
            obj.TenTheLoai = theLoai.TenTheLoai;
            context.theLoais.Update(obj);
            context.SaveChanges();
            return true;
        }
    }
}
