using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BTTT7.Models;

[Table("tNhanVien")]
public partial class TNhanVien
{
    [Key]
    [Column("MaNV")]
    [StringLength(3)]
    public string MaNv { get; set; } = null!;

    [Column("HO")]
    [StringLength(15)]
    public string? Ho { get; set; }

    [Column("TEN")]
    [StringLength(7)]
    public string? Ten { get; set; }

    [Column("PHAI")]
    public bool Phai { get; set; }

    [Column("NTNS", TypeName = "datetime")]
    public DateTime? Ntns { get; set; }

    [Column("NgayBD", TypeName = "datetime")]
    public DateTime? NgayBd { get; set; }

    [Column("MaPB")]
    [StringLength(2)]
    public string? MaPb { get; set; }

    [Column("HINH", TypeName = "image")]
    public byte[]? Hinh { get; set; }

    [Column("GHICHU")]
    public string? Ghichu { get; set; }

    [ForeignKey("MaPb")]
    [InverseProperty("TNhanViens")]
    public virtual TPhongBan? MaPbNavigation { get; set; }

    [InverseProperty("MaNvNavigation")]
    public virtual TChiTietNhanVien? TChiTietNhanVien { get; set; }
}
