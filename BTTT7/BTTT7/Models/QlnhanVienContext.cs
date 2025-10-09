using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BTTT7.Models;

public partial class QLNhanVienContext : DbContext
{
    public QLNhanVienContext()
    {
    }

    public QLNhanVienContext(DbContextOptions<QLNhanVienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TChiTietNhanVien> TChiTietNhanViens { get; set; }

    public virtual DbSet<TNhanVien> TNhanViens { get; set; }

    public virtual DbSet<TPhongBan> TPhongBans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-LGFQB3M\\SQLEXPRESS;Initial Catalog=QLNhanVien;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TChiTietNhanVien>(entity =>
        {
            entity.HasOne(d => d.MaNvNavigation).WithOne(p => p.TChiTietNhanVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tChiTietNhanVien_tNhanVien");
        });

        modelBuilder.Entity<TNhanVien>(entity =>
        {
            entity.HasOne(d => d.MaPbNavigation).WithMany(p => p.TNhanViens).HasConstraintName("FK_tNhanVien_tPhongBan1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
