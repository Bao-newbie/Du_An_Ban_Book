using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKhachHangRepositories
    {
        bool Add(KhachHang khachHang);
        bool Update(KhachHang khachHang);
        bool Delete(KhachHang khachHang);
        List<KhachHang> GetAll();
    }
}
