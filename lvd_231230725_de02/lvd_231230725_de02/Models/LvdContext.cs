using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace lvd_231230725_de02.Models;

public partial class LvdContext : DbContext
{
    public LvdContext()
    {
    }

    public LvdContext(DbContextOptions<LvdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LvdCatalog> LvdCatalogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-LGFQB3M\\SQLEXPRESS;Database=LuongVietDoanh_231230725_de02;Trusted_Connection=True;TrustServerCertificate=True", x => x.UseNetTopologySuite());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LvdCatalog>(entity =>
        {
            entity.HasKey(e => e.LvdId).HasName("PK__LvdCatal__57B125F0CCEA2B3B");

            entity.ToTable("LvdCatalog");

            entity.Property(e => e.LvdId).HasColumnName("lvdId");
            entity.Property(e => e.LvdCateActive).HasColumnName("lvdCateActive");
            entity.Property(e => e.LvdCateName)
                .HasMaxLength(50)
                .HasColumnName("lvdCateName");
            entity.Property(e => e.LvdCatePrice)
                .HasMaxLength(100)
                .HasColumnName("lvdCatePrice");
            entity.Property(e => e.LvdCateQty)
                .HasMaxLength(100)
                .HasColumnName("lvdCateQty");
            entity.Property(e => e.LvdPicture)
                .HasMaxLength(100)
                .HasColumnName("lvdPicture");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
