using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface ITacGiaService
    {
        bool Add(TacGiaView obj);
        bool Delete(TacGiaView obj);
        bool Update(TacGiaView obj);
        List<TacGiaView> GetAll();
    }
}
