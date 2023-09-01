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
    public class KhachHangConfiguration: IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.HasKey(c => c.IDKhachHang);
            builder.Property(c => c.MaKH);
            builder.Property(c => c.Ten);
            builder.Property(c => c.DiaChi);
            builder.Property(c => c.SDT);

        }
    }
}
