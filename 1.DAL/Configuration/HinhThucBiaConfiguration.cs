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
    public class HinhThucBiaConfiguration: IEntityTypeConfiguration<HinhThucBia>
    {
        public void Configure (EntityTypeBuilder<HinhThucBia> builder)
        {
            builder.HasKey(c => c.idBia);
            builder.Property(c => c.LoaiBia);

            
        }
    }
}
