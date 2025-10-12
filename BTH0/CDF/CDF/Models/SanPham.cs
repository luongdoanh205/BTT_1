using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDF.Models
{
    public class SanPham
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(50)]
        public string MaSanPham { get; set; }

        [Required, StringLength(200)]
        public string TenSanPham { get; set; }

        public string? HinhAnh { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DonGia { get; set; }

        public int MaLoai { get; set; }
        public LoaiSanPham LoaiSanPham { get; set; }

        public bool TrangThai { get; set; }

        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
