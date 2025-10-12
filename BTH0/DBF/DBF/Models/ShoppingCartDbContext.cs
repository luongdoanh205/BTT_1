using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBF.Models;

public partial class ShoppingCartDbContext : DbContext
{
    public ShoppingCartDbContext()
    {
    }

    public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<QuanTri> QuanTris { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-LGFQB3M\\SQLEXPRESS;Initial Catalog=ShoppingCartDB;Integrated Security=True;Trust Server Certificate=True;Encrypt=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietHoaDon>(entity =>
        {
            entity.HasOne(d => d.SanPham).WithMany(p => p.ChiTietHoaDons).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.HoaDons).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.SanPhams).OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
