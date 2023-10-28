using _1.DAL.Repositories;
using _1.DAL.IRepositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;
using Du_An_Ban_Sach._1.DAL.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Service
{
    public class HinhThucBiaService : IHinhThucBiaService
    {
        IHinhThucBiaRepositories iHinhThucBiaRp;
        List<HinhThucBia> lstHinhThucBia;
       
        public HinhThucBiaService()
        {
            iHinhThucBiaRp = new HinhThucBiaRepositories();
            

        }
        public bool Add(HinhThucBiaView hinhThucBiaView)
        {
            if (hinhThucBiaView == null) return false;
            var hinhthucBia = new HinhThucBia()
            {
                idBia = Guid.NewGuid(),
                MaBia= hinhThucBiaView.MaBia,
                LoaiBia = hinhThucBiaView.LoaiBia
            };
            if(iHinhThucBiaRp.Add(hinhthucBia)) return true;
            return false;
        }

        public bool Delete(HinhThucBiaView hinhThucBiaView)
        {
            if (hinhThucBiaView == null) return false;
            var bia = iHinhThucBiaRp.GetAll().FirstOrDefault(c => c.idBia == hinhThucBiaView.idBia);
            if (iHinhThucBiaRp.Delete(bia)) return true;
            return false;
        }

        public List<HinhThucBiaView> GetAll()
        {
            List<HinhThucBiaView> lst = new List<HinhThucBiaView> ();
            lst = (
                from a in iHinhThucBiaRp.GetAll()
                select new HinhThucBiaView()
                {
                    idBia = a.idBia,
                    MaBia = a.MaBia,
                    LoaiBia = a.LoaiBia,
                }
                ).ToList();
            return lst;
        }

        public bool Update(HinhThucBiaView hinhThucBiaView)
        {
            if (hinhThucBiaView == null) return false;
            var bia = iHinhThucBiaRp.GetAll().FirstOrDefault(c => c.idBia == hinhThucBiaView.idBia);
            bia.MaBia = hinhThucBiaView.MaBia;
            bia.LoaiBia = hinhThucBiaView.LoaiBia;
            if (iHinhThucBiaRp.Update(bia)) return true;
            return false;
        }
    }
}
