using Microsoft.EntityFrameworkCore;
namespace SportsStore.Models
{
    public class HaberDbContext : DbContext
    {
        public HaberDbContext(DbContextOptions<HaberDbContext> options)
            : base(options) { }
        public DbSet<Haber> Habers { get; set; }
    }
}
