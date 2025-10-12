using System.ComponentModel.DataAnnotations;

namespace CDF.Models
{
    public class KhachHang
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(50)]
        public string MaKhachHang { get; set; }

        [Required, StringLength(100)]
        public string HoTenKhachHang { get; set; }

        [Required, StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string? MatKhau { get; set; }

        [StringLength(20)]
        public string? DienThoai { get; set; }

        [StringLength(200)]
        public string? DiaChi { get; set; }

        public DateTime NgayDangKy { get; set; } = DateTime.Now;

        public bool TrangThai { get; set; }

        // Quan hệ
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
