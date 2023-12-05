using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configuration
{
    public class NhanVienConfiguartion : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MaNV);
            builder.Property(x => x.HoTen);
            builder.Property(x => x.Email);
            builder.Property(x => x.SDT);
            builder.Property(x => x.DiaChi);
            builder.Property(x => x.ChucVu);
            builder.Property(x => x.TrangThai);
            builder.Property(x => x.Password);
        }
    }
}
