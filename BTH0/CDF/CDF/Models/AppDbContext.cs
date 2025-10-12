using Microsoft.EntityFrameworkCore;

namespace CDF.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<QuanTri> QuanTris { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPham>()
                .HasOne(sp => sp.LoaiSanPham)
                .WithMany(lsp => lsp.SanPhams)
                .HasForeignKey(sp => sp.MaLoai)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDon>()
                .HasOne(hd => hd.KhachHang)
                .WithMany(kh => kh.HoaDons)
                .HasForeignKey(hd => hd.MaKhachHang)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(ct => ct.HoaDon)
                .WithMany(hd => hd.ChiTietHoaDons)
                .HasForeignKey(ct => ct.HoaDonID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(ct => ct.SanPham)
                .WithMany(sp => sp.ChiTietHoaDons)
                .HasForeignKey(ct => ct.SanPhamID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
