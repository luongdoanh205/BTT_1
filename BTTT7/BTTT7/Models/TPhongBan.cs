using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BTTT7.Models;

[Table("tPhongBan")]
public partial class TPhongBan
{
    [Key]
    [Column("MaPB")]
    [StringLength(2)]
    public string MaPb { get; set; } = null!;

    [Column("TENPB")]
    [StringLength(30)]
    public string? Tenpb { get; set; }

    [StringLength(3)]
    public string? TruongPhong { get; set; }

    [InverseProperty("MaPbNavigation")]
    public virtual ICollection<TNhanVien> TNhanViens { get; set; } = new List<TNhanVien>();
}
