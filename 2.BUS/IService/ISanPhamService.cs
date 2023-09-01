using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface ISanPhamService
    {
        bool Add(SanPhamView obj);
        bool Delete(SanPhamView obj);
        bool Update(SanPhamView obj);
        string? GetByName(string? name);
        List<SanPhamView> GetAll();
    }
}
