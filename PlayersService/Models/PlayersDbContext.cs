using Microsoft.EntityFrameworkCore;

namespace PlayersService.Models
{
    public class PlayersDbContext:DbContext
    {
        public PlayersDbContext(DbContextOptions<PlayersDbContext> options) : base(options)
        { }

        public DbSet<Players> players { get; set; }
    
     }
}
