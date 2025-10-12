using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDF.Models
{
    public class HoaDon
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(50)]
        public string MaHoaDon { get; set; }

        public int MaKhachHang { get; set; }
        public KhachHang KhachHang { get; set; }

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

        [Column(TypeName = "decimal(18,2)")]
        public decimal TongTriGia { get; set; }

        public bool TrangThai { get; set; }

        // Quan hệ
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
