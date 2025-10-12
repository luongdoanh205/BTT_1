using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBF.Models;

[Index("HoaDonId", Name = "IX_ChiTietHoaDons_HoaDonID")]
[Index("SanPhamId", Name = "IX_ChiTietHoaDons_SanPhamID")]
public partial class ChiTietHoaDon
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("HoaDonID")]
    public int HoaDonId { get; set; }

    [Column("SanPhamID")]
    public int SanPhamId { get; set; }

    public int SoLuongMua { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal DonGiaMua { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ThanhTien { get; set; }

    public bool TrangThai { get; set; }

    [ForeignKey("HoaDonId")]
    [InverseProperty("ChiTietHoaDons")]
    public virtual HoaDon HoaDon { get; set; } = null!;

    [ForeignKey("SanPhamId")]
    [InverseProperty("ChiTietHoaDons")]
    public virtual SanPham SanPham { get; set; } = null!;
}
