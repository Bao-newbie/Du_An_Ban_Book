using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Service
{
    public class NhanVienServices : INhanVienServices
    {
        INhanVienRepositories iNhanVien;
        public NhanVienServices()
        {
            iNhanVien = new NhanVienRepositories();
        }
        public bool Add(NhanVienView nhanVienView)
        {
            if (nhanVienView == null) return false;
            var nv = new NhanVien()
            {
                Id = Guid.NewGuid(),
                HoTen = nhanVienView.HoTen,
                Email = nhanVienView.Email,
                SDT = nhanVienView.SDT,
                DiaChi = nhanVienView.DiaChi,
                ChucVu = nhanVienView.ChucVu,
                TrangThai = nhanVienView.TrangThai,
                Password = nhanVienView.Password,
            };
            if (iNhanVien.Add(nv)) return true;
            return false;
        }

        public bool Delete(NhanVienView nhanVienView)
        {
            if (nhanVienView == null) return false;
            var nv = iNhanVien.GetAll().FirstOrDefault(c => c.Id == nhanVienView.idNV);
            if (iNhanVien.Delete(nv)) return true;
            return false;
        }

        public List<NhanVienView> GetAll()
        {
            List<NhanVienView> lst = new List<NhanVienView>();
            lst = (from a in iNhanVien.GetAll()
                   select new NhanVienView
                   {
                       idNV = a.Id,
                       HoTen = a.HoTen,
                       Email = a.Email,
                       SDT = a.SDT,
                       DiaChi = a.DiaChi,
                       ChucVu = a.ChucVu,
                       TrangThai = a.TrangThai,
                       Password = a.Password,
                   }).ToList();
            return lst;
        }

        public bool Update(NhanVienView nhanVienView)
        {
            if (nhanVienView == null) return false;
            var nv = iNhanVien.GetAll().FirstOrDefault(x=>x.Id == nhanVienView.idNV);
            nv.HoTen = nhanVienView.HoTen;
            nv.Email= nhanVienView.Email;
            nv.SDT = nhanVienView.SDT;
            nv.DiaChi = nhanVienView.DiaChi;
            nv.ChucVu= nhanVienView.ChucVu;
            nv.TrangThai = nhanVienView.TrangThai;
            nv.Password = nhanVienView.Password;
            if (iNhanVien.Update(nv)) return true;
            return false;
        }
    }
}
