using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface INXBService
    {
        bool Add(NXBView obj);
        bool Delete(NXBView obj);
        bool Update(NXBView obj);
        List<NXBView> GetAll();
    }
}
