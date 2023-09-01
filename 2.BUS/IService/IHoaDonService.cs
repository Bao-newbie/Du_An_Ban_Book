using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IHoaDonService
    {
        bool Add(HoaDonView obj);
        bool Delete(HoaDonView obj);
        bool Update(HoaDonView obj);
        List<HoaDonView> GetAll();
    }
}
