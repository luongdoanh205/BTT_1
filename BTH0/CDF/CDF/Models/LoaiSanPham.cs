using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CDF.Models
{
    public class LoaiSanPham
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(50)]
        public string MaLoai { get; set; }

        [Required, StringLength(100)]
        public string TenLoai { get; set; }

        public bool TrangThai { get; set; }

        // Quan hệ
        public ICollection<SanPham> SanPhams { get; set; }
    }
}
