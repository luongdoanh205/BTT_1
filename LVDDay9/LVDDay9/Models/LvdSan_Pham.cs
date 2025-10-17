using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LVDDay9.Models
{
    [Table("LvdSan_Pham")]
    public class LvdSan_Pham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long lvdId { get; set; }

        [Display(Name = "Mã sản phẩm")]
        [Required]
        [StringLength(10)]
        public string lvdMaSanPham { get; set; }

        [Display(Name = "Tên sản phẩm")]
        public string lvdTenSanPham { get; set; }

        [Display(Name = "Hình ảnh")]
        public string lvdHinhAnh { get; set; }

        [Display(Name = "Số lượng")]
        public int lvdSoLuong { get; set; }

        [Display(Name = "Đơn giá")]
        public decimal lvdDonGia { get; set; }


        public long lvdLoaiSanPhamId { get; set; }

        public LvdLoai_San_Pham lvdLoai_San_Pham { get; set; }

    }
}
