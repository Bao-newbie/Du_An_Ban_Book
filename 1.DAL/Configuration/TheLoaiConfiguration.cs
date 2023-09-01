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
    public class TheLoaiConfiguration : IEntityTypeConfiguration<TheLoai>
    {
        public void Configure(EntityTypeBuilder<TheLoai> builder)
        {
            builder.HasKey(c => c.IDTheLoai);
            builder.Property(c => c.MaTheLoai);
            builder.Property(c => c.TenTheLoai);
        }
    }
}
