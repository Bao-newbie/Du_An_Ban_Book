using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;
using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Service
{
    public class HoaDonChiTietService : IHoaDonChiTietService
    {
        IHoaDonChiTietRepositories iHDCT;
        IHoaDonRepositories iHD;
        ISanPhamRepositories iSP;
        public HoaDonChiTietService()
        {
            iHDCT = new HoaDonChiTietRepositories();
            iHD = new HoaDonRepositories();
            iSP = new SanPhamRepositories();
        }
        public bool Add(HoaDonChiTietvIEW obj)
        {
            if (obj == null) return false;
            var ncc = new HoaDonChiTiet()
            {
                IDHoaDonChiTiet = Guid.NewGuid(),
                idHoaDon = obj.IdHoaDon,
                idSanPham = obj.idSanPham,
                MaHDCT = obj.MaHDCt,
                SoLuong = obj.soLuong,
                TongTien = obj.tongTien,
            };
            if (iHDCT.Add(ncc)) return true;
            return false;
        }

        public bool Delete(HoaDonChiTietvIEW obj)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonChiTietvIEW> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(HoaDonChiTietvIEW obj)
        {
            throw new NotImplementedException();
        }
    }
}
