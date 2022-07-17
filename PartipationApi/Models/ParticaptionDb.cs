using Microsoft.EntityFrameworkCore;
using ParticipationApi.Models;

namespace PartipationApi.Models
{
    public class ParticaptionDb : DbContext

    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ParticaptionDb(DbContextOptions options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {


        }
        DbSet<Participations> Participations { get; set; }
    }
}
