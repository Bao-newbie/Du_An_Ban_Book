using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonChiTietRepositories
    {
        bool Add(HoaDonChiTiet hoaDonChiTiet);
        bool Update(HoaDonChiTiet hoaDonChiTiet);
        bool Delete(HoaDonChiTiet hoaDonChiTiet);
        List<HoaDonChiTiet> GetAll();
    }
}
