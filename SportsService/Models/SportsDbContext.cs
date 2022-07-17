using Microsoft.EntityFrameworkCore;

namespace SportsService.Models
{
    public class SportsDbContext:DbContext
    {
        public SportsDbContext(DbContextOptions<SportsDbContext> options) : base(options)
        { }

        public DbSet<Sports> sports { get; set; }
    }
}
