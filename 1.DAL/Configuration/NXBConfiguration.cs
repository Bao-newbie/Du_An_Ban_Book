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
    public class NXBConfiguration :IEntityTypeConfiguration<NXB>
    {
        public void Configure(EntityTypeBuilder<NXB> builder)
        {
            builder.HasKey(c => c.IDNXB);
            builder.Property(c => c.MaNXB);
            builder.Property(c => c.TenNXB);
            builder.Property(c => c.SDT);
            builder.Property(c => c.DiaChi);
        }
    }
}
