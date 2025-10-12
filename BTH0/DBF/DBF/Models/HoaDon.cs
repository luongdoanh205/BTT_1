using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBF.Models;

[Index("MaKhachHang", Name = "IX_HoaDons_MaKhachHang")]
public partial class HoaDon
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string MaHoaDon { get; set; } = null!;

    public int MaKhachHang { get; set; }

    public DateTime NgayHoaDon { get; set; }

    public DateTime? NgayNhan { get; set; }

    [StringLength(100)]
    public string? HoTenKhachHang { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(20)]
    public string? DienThoai { get; set; }

    [StringLength(200)]
    public string? DiaChi { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TongTriGia { get; set; }

    public bool TrangThai { get; set; }

    [InverseProperty("HoaDon")]
    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    [ForeignKey("MaKhachHang")]
    [InverseProperty("HoaDons")]
    public virtual KhachHang MaKhachHangNavigation { get; set; } = null!;
}
