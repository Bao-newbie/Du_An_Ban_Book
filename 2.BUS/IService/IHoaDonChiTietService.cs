using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IHoaDonChiTietService
    {
        bool Add(HoaDonChiTietvIEW obj);
        bool Delete(HoaDonChiTietvIEW obj);
        bool Update(HoaDonChiTietvIEW obj);
        List<HoaDonChiTietvIEW> GetAll();
    }
}
