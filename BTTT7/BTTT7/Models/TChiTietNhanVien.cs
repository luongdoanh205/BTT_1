using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BTTT7.Models;

[Table("tChiTietNhanVien")]
public partial class TChiTietNhanVien
{
    [Key]
    [Column("MaNV")]
    [StringLength(3)]
    public string MaNv { get; set; } = null!;

    [StringLength(3)]
    public string? ChucVu { get; set; }

    [Column("HSLuong")]
    public byte? Hsluong { get; set; }

    [Column("MucDoCV")]
    [StringLength(2)]
    public string? MucDoCv { get; set; }

    [Column("GTGC")]
    public byte? Gtgc { get; set; }

    [ForeignKey("MaNv")]
    [InverseProperty("TChiTietNhanVien")]
    public virtual TNhanVien MaNvNavigation { get; set; } = null!;
}
