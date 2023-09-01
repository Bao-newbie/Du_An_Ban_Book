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
    public class SanPhamConfiguration : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.HasKey(c => c.IDsanPham);
            builder.Property(c => c.MaSach);
            builder.Property(c => c.TenSach);
            builder.Property(c => c.Anh);

            builder.HasOne(c => c.HinhThucBia).WithMany(c => c.SanPhams).HasForeignKey(c => c.idHinhThucBia);
            builder.HasOne(c => c.NXB).WithMany(c => c.SanPhams).HasForeignKey(c => c.idNXB);
            builder.HasOne(c => c.NhaCungCap).WithMany(c => c.SanPhams).HasForeignKey(c => c.idNhaCungCap);
            builder.HasOne(c => c.TheLoai).WithMany(c => c.SanPhams).HasForeignKey(c => c.idTheLoai);
            builder.HasOne(c => c.TacGia).WithMany(c => c.SanPhams).HasForeignKey(c => c.IdTacGia);
        }
    }
}
