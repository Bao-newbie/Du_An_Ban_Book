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
    public class HoaDonService : IHoaDonService
    {
      
        IHoaDonRepositories iHDRepository;
        IKhachHangRepositories iKhachHangRepositories;
        public HoaDonService()
        {
       
            iHDRepository = new HoaDonRepositories();
            iKhachHangRepositories = new KhachHangRepositories();
        }
        public bool Add(HoaDonView obj)
        {
            if (obj == null) return false;
            var ncc = new HoaDon()
            {
                IDHoaDon = obj.iDhoaDon,
                idKhachHang = obj.iDkhachHang,
                MaHD = obj.MaHD,
                NgayThanhToan = obj.ngayThanhToan,
                TrangThai = obj.trangThai,
                
            };
            if (iHDRepository.Add(ncc)) return true;
            return false;
        }

        public bool Delete(HoaDonView obj)
        {
            if (obj == null) return false;
            var ncc = iHDRepository.GetAll().FirstOrDefault(c => c.IDHoaDon == obj.iDhoaDon);
            if (iHDRepository.Delete(ncc)) return true;
            return false;
        }

        public List<HoaDonView> GetAll()
        {
            List<HoaDonView> lst = new List<HoaDonView> ();
            lst = (from a in iHDRepository.GetAll()
                   join b in iKhachHangRepositories.GetAll() on a.idKhachHang equals b.IDKhachHang
                   select new HoaDonView()
                   {
                       iDhoaDon = a.IDHoaDon,
                       iDkhachHang = b.IDKhachHang,
                       MaHD = a.MaHD,
                       ngayThanhToan = a.NgayThanhToan,
                       trangThai = a.TrangThai,

                       tenKH = b.Ten,
                       maKH = b.MaKH,
                   }).ToList ();
            return lst;
        }

        public bool Update(HoaDonView obj)
        {
            if (obj == null) return false;
            var ncc = iHDRepository.GetAll().FirstOrDefault(c => c.IDHoaDon == obj.iDhoaDon);
            ncc.MaHD = obj.MaHD;
            ncc.idKhachHang = obj.iDkhachHang;
            ncc.NgayThanhToan = obj.ngayThanhToan;
            ncc.TrangThai = obj.trangThai;
            
            if (iHDRepository.Update(ncc)) return true;
            return false;
        }
    }
}
