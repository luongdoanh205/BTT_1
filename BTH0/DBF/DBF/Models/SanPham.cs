using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBF.Models;

[Index("MaLoai", Name = "IX_SanPhams_MaLoai")]
public partial class SanPham
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string MaSanPham { get; set; } = null!;

    [StringLength(200)]
    public string TenSanPham { get; set; } = null!;

    public string? HinhAnh { get; set; }

    public int SoLuong { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal DonGia { get; set; }

    public int MaLoai { get; set; }

    public bool TrangThai { get; set; }

    [InverseProperty("SanPham")]
    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    [ForeignKey("MaLoai")]
    [InverseProperty("SanPhams")]
    public virtual LoaiSanPham MaLoaiNavigation { get; set; } = null!;
}
