using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBF.Models;

public partial class KhachHang
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string MaKhachHang { get; set; } = null!;

    [StringLength(100)]
    public string HoTenKhachHang { get; set; } = null!;

    [StringLength(100)]
    public string Email { get; set; } = null!;

    [StringLength(100)]
    public string? MatKhau { get; set; }

    [StringLength(20)]
    public string? DienThoai { get; set; }

    [StringLength(200)]
    public string? DiaChi { get; set; }

    public DateTime NgayDangKy { get; set; }

    public bool TrangThai { get; set; }

    [InverseProperty("MaKhachHangNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
