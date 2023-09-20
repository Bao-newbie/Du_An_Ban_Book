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

            if (obj == null) return false;
            var ncc = iHDCT.GetAll().FirstOrDefault(c => c.IDHoaDonChiTiet == obj.idHoaDonCT);
            if (iHDCT.Delete(ncc)) return true;
            return false;
        }

        public List<HoaDonChiTietvIEW> GetAll()
        {
            List<HoaDonChiTietvIEW> lst = new List<HoaDonChiTietvIEW> ();
            lst = (from a in iHDCT.GetAll()
                   join b in iHD.GetAll() on a.idHoaDon equals b.IDHoaDon
                   join c in iSP.GetAll() on a.idSanPham equals c.IDsanPham
                   select new HoaDonChiTietvIEW()
                   {
                       idHoaDonCT = a.IDHoaDonChiTiet,
                       IdHoaDon = b.IDHoaDon,     
                       idSanPham = c.IDsanPham,
                       MaHDCt = a.MaHDCT,
                       soLuong =a.SoLuong,
                       tongTien = a.TongTien,

                       tenSach = c.TenSach,
                       giaBan = c.GiaBan,
                       soLuongTon = c.SoLuongTon,

                   }
                   ).ToList ();
            return lst;
        }

        public bool Update(HoaDonChiTietvIEW obj)
        {

            if (obj == null) return false;
            var ncc = iHDCT.GetAll().FirstOrDefault(c => c.IDHoaDonChiTiet == obj.idHoaDonCT);
            ncc.MaHDCT = obj.MaHDCt;
            ncc.idHoaDon = obj.IdHoaDon;
            ncc.idSanPham = obj.idSanPham;
            ncc.SoLuong = obj.soLuong;
            ncc.TongTien = obj.tongTien;
            if (iHDCT.Update(ncc)) return true;
            return false;
        }
    }
}
