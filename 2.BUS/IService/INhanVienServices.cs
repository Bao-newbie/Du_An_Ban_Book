using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface INhanVienServices
    {
        bool Add(NhanVienView nhanVienView);
        bool Update(NhanVienView nhanVienView);
        bool Delete(NhanVienView nhanVienView);
        List<NhanVienView> GetAll();
    }
}
