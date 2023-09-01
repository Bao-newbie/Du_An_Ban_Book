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
    public class SanPhamService : ISanPhamService
    {
        ITacGiaRepositories tacGiaRP;
        INhaCungCapRepositories NhaCungCapRP;
        INXBRepositories NXBRP;
        ITheLoaiRepositories theLoaiRP;
        IHinhThucBiaRepositories HinhThucBiaRP;
        ISanPhamRepositories SanPhamRP;
       
        public SanPhamService()
        {
            tacGiaRP = new TacGiaRepositories();
            NhaCungCapRP = new NhaCungCapRepositories();
            NXBRP = new NXBRepositories();
            theLoaiRP = new TheLoaiRepositories();
            HinhThucBiaRP = new HinhThucBiaRepositories();
            SanPhamRP = new SanPhamRepositories();
           
        }


        public bool Add(SanPhamView obj)
        {
            if (obj == null) return false;
            var sp = new SanPham()
            {
                IDsanPham = Guid.NewGuid(),
                MaSach = obj.MaSP,
                TenSach = obj.TenSach,
                SoLuongTon = obj.SoLuongTon,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                Anh = obj.Anh,
                MoTa = obj.MoTa,
                TrangThai = obj.TrangThai,
                IdTacGia = obj.idTacGia,
                idHinhThucBia = obj.idHinhThucBia,
                idNhaCungCap = obj.idNhaCungCap,
                idNXB = obj.idNXB,
                idTheLoai = obj.idTheLoai,
            };
            if(SanPhamRP.Add(sp)) return true;  
            return false;
        }


        public bool Delete(SanPhamView obj)
        {
            if(obj == null) return false;
            var sp = SanPhamRP.GetAll().FirstOrDefault(c => c.IDsanPham == obj.IDsanPham);
            if(SanPhamRP.Delete(sp)) return true;
            return false;
        }

        public List<SanPhamView> GetAll()
        {
            List<SanPhamView> lst = new List<SanPhamView>();
            lst = (
                from a in SanPhamRP.GetAll()
                join b in tacGiaRP.GetAll() on a.IdTacGia equals b.idTacGia
                join c in theLoaiRP.GetAll() on a.idTheLoai equals c.IDTheLoai
                join d in HinhThucBiaRP.GetAll() on a.idHinhThucBia equals d.idBia
                join e in NhaCungCapRP.GetAll() on a.idNhaCungCap equals e.IDNhaCungCap
                join g in NXBRP.GetAll() on a.idNXB equals g.IDNXB
                select new SanPhamView()
                {
                    IDsanPham = a.IDsanPham,
                    idTacGia = b.idTacGia,
                    idTheLoai = c.IDTheLoai,
                    idHinhThucBia = d.idBia,
                    idNhaCungCap = e.IDNhaCungCap,
                    idNXB = g.IDNXB,

                    MaSP = a.MaSach,
                    TenSach = a.TenSach,
                    SoLuongTon = a.SoLuongTon,
                    GiaNhap = a.GiaNhap,
                    GiaBan = a.GiaBan,
                    Anh = a.Anh,
                    MoTa = a.MoTa,
                    TrangThai = a.TrangThai,

                    TenTG = b.Ten,
                    TenTheLoai = c.TenTheLoai,
                    LoaiBia = d.LoaiBia,
                    TenNCC = e.TenNhaCungCap,
                    TenNXB = g.TenNXB,

                }
                 ).ToList();
            return lst;
        }

        public string? GetByName(string? name)
        {
            return GetAll().FirstOrDefault(c => c.MaSP == name).TenSach;
        }

        public bool Update(SanPhamView obj)
        {
            if(obj == null) return false;
            var sp = SanPhamRP.GetAll().FirstOrDefault(c => c.IDsanPham == obj.IDsanPham);
            sp.TenSach = obj.TenSach;
            sp.MaSach = obj.MaSP;
            sp.TenSach = obj.TenSach;
            sp.SoLuongTon = obj.SoLuongTon;
            sp.GiaNhap = obj.GiaNhap;
            sp.GiaBan = obj.GiaBan;
            sp.Anh = obj.Anh;
            sp.MoTa = obj.MoTa;
            sp.TrangThai = obj.TrangThai;
            sp.IdTacGia = obj.idTacGia;
            sp.idHinhThucBia = obj.idHinhThucBia;
            sp.idNhaCungCap = obj.idNhaCungCap;
            sp.idNXB = obj.idNXB;
            sp.idTheLoai = obj.idTheLoai;
            if(SanPhamRP.Update(sp)) return true;
            return false;

        }
    }
}
