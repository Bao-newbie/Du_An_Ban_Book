using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface ITheLoaiService
    {
        bool Add(TheLoaiView obj);
        bool Delete(TheLoaiView obj);
        bool Update(TheLoaiView obj);
        List<TheLoaiView> GetAll();
    }
}
