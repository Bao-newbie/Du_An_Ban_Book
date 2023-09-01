using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INXBRepositories
    {
        bool Add(NXB nXB);
        bool Update(NXB nXB);
        bool Delete(NXB nXB);
        List<NXB> GetAll();
    }
}
