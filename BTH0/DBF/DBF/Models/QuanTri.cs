using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBF.Models;

public partial class QuanTri
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string TaiKhoan { get; set; } = null!;

    [StringLength(100)]
    public string MatKhau { get; set; } = null!;

    public bool TrangThai { get; set; }
}
