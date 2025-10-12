
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDF.Models
{
    public class ChiTietHoaDon
    {
        [Key]
        public int ID { get; set; }

        public int HoaDonID { get; set; }
        public HoaDon HoaDon { get; set; }

        public int SanPhamID { get; set; }
        public SanPham SanPham { get; set; }

        public int SoLuongMua { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DonGiaMua { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ThanhTien { get; set; }

        public bool TrangThai { get; set; }
    }
}
