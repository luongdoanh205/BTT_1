using Microsoft.EntityFrameworkCore;

namespace LVDDay9.Models
{
    public class LVDDay9Context : DbContext
    {
        public LVDDay9Context (DbContextOptions<LVDDay9Context> options)
            : base(options)
        {
        }
        public DbSet<LVDDay9.Models.LvdLoai_San_Pham> LvdLoai_San_Pham { get; set; } = default!;
        public DbSet<LVDDay9.Models.LvdSan_Pham> LvdSan_Pham { get; set; } = default!;
    }
}
