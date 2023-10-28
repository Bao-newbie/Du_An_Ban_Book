using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INhanVienRepositories
    {
        bool Add(NhanVien nhanVien);
        bool Update(NhanVien nhanVien);
        bool Delete(NhanVien nhanVien);
        List<NhanVien> GetAll();
    }
}
