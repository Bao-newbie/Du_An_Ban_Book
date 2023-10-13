using Du_An_Ban_Sach._1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.SachDbContext
{
    public class DbSach : DbContext
    {
        public DbSach()
        {
            
        }

        public DbSach(DbContextOptions options) : base(options)
        {

        }

        public DbSet<HinhThucBia> hinhThucBias { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<HoaDonChiTiet> hoaDonChiTiets { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<NXB> nXBs { get; set; }
        public DbSet<NhaCungCap> nhaCungCaps { get; set; }
        public DbSet<TacGia> tacGias { get; set; }
        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<TheLoai> theLoais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=POOR-LAPTOP;Initial Catalog=BookStore;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
