using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LVDDay9.Models
{
    [Table("LvdLoai_San_Pham")]
    [Index(nameof(lvdMaLoai), IsUnique = true)]
    public class LvdLoai_San_Pham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long lvdId { get; set; }

        [Display(Name = "Mã loại")]
        [StringLength(10)]
        public string lvdMaLoai { get; set; }

        [Display(Name = "Tên loại")]
        [StringLength(50)]
        public string lvdTenLoai { get; set; }

        [Display(Name = "Trạng thái")]
        public bool lvdTrangThai { get; set; }

        public ICollection<LvdSan_Pham> lvdSan_Phams { get; set; } = new HashSet<LvdSan_Pham>();
    }
}
