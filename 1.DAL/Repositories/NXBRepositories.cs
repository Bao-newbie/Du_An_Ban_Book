
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
    public class NXBRepositories : INXBRepositories
    {
        DbSach context;
        public NXBRepositories()
        {
            context = new DbSach();
        }
        public bool Add(NXB nXB)
        {
            if (nXB == null)
            {
                return false;
            }
            context.nXBs.Add(nXB);
            context.SaveChanges();
            return true;
        }

        public bool Delete(NXB nXB)
        {
            if (nXB == null)
            {
                return false;
            }
            var obj = context.nXBs.FirstOrDefault(c => c.IDNXB == nXB.IDNXB);
            context.nXBs.Remove(nXB);
            context.SaveChanges();
            return true;
        }

        public List<NXB> GetAll()
        {
            return context.nXBs.ToList();
        }

        public bool Update(NXB nXB)
        {
            if (nXB == null)
            {
                return false;
            }
            var obj = context.nXBs.FirstOrDefault(c => c.IDNXB == nXB.IDNXB);
            obj.IDNXB = nXB.IDNXB;
            obj.MaNXB = nXB.MaNXB;
            obj.TenNXB = nXB.TenNXB;
            obj.SDT = nXB.SDT;
            obj.DiaChi = nXB.DiaChi;
            context.nXBs.Update(obj);
            context.SaveChanges();
            return true;
        }
    }
}
