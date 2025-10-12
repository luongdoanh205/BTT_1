using System.ComponentModel.DataAnnotations;

namespace CDF.Models
{
    public class QuanTri
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(50)]
        public string TaiKhoan { get; set; }

        [Required, StringLength(100)]
        public string MatKhau { get; set; }

        public bool TrangThai { get; set; }
    }
}
