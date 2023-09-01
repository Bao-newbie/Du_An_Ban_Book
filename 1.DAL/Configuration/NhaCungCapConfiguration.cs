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
    public class NhaCungCapConfiguration : IEntityTypeConfiguration<NhaCungCap>
    {
        public void Configure(EntityTypeBuilder<NhaCungCap> builder)
        {
            builder.HasKey(c => c.IDNhaCungCap);
            builder.Property(c => c.MaNCC);
            builder.Property(c => c.TenNhaCungCap);
            builder.Property(c => c.SdtNCC);
            builder.Property(c => c.DiaCHi);
        }
    }
}
