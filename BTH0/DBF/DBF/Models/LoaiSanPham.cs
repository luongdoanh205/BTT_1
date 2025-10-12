using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBF.Models;

public partial class LoaiSanPham
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string MaLoai { get; set; } = null!;

    [StringLength(100)]
    public string TenLoai { get; set; } = null!;

    public bool TrangThai { get; set; }

    [InverseProperty("MaLoaiNavigation")]
    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
