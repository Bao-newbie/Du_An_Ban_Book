using Du_An_Ban_Sach._1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configuration
{
    public class HoaDonChiTietConfiguration: IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.HasKey(c => c.IDHoaDonChiTiet);
            builder.Property(c => c.MaHDCT);
            builder.HasOne(c=>c.HoaDon).WithMany(c=>c.HoaDonChiTiets).HasForeignKey(c=>c.idHoaDon);
            builder.HasOne(c => c.SanPham).WithMany(c => c.HoaDonChiTiets).HasForeignKey(c => c.idSanPham);
        }
    }
}
