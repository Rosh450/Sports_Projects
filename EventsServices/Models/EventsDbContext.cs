using Microsoft.EntityFrameworkCore;

namespace EventsServices.Models
{
    public class EventsDbContext:DbContext
    {
        public EventsDbContext(DbContextOptions<EventsDbContext> options) : base(options)
        { }

        public DbSet<Events> events { get; set; }
    }
}
