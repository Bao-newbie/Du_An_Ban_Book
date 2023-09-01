using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IKhachHangService
    {
        bool Add(KhachHangView obj);
        bool Delete(KhachHangView obj);
        bool Update(KhachHangView obj);
        List<KhachHangView> GetAll();
    }
}
