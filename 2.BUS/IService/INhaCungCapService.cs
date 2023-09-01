using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface INhaCungCapService
    {
        bool Add(NhaCungCapView obj);
        bool Delete(NhaCungCapView obj);
        bool Update(NhaCungCapView obj);
        List<NhaCungCapView> GetAll();
    }
}
