using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonRepositories
    {
        bool Add(HoaDon hoaDon);
        bool Update(HoaDon hoaDon);
        bool Delete(HoaDon hoaDon);
        List<HoaDon> GetAll();
    }
}
