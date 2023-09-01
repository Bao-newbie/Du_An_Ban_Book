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
    public class TacGiaConfiguration : IEntityTypeConfiguration<TacGia>
    {
        public void Configure(EntityTypeBuilder<TacGia> builder)
        {
            builder.HasKey(c => c.idTacGia);
            builder.Property(c => c.MaTG);
            builder.Property(c => c.Ten);
            builder.Property(c => c.DiaChi);
            builder.Property(c => c.Email);
            builder.Property(c => c.SDT);
        }
    }
}
