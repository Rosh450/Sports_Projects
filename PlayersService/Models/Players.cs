using System.ComponentModel.DataAnnotations;

namespace PlayersService.Models
{
    public class Players
    {
        [Key]
        public int playerid { get; set; }
        public string playername { get; set; }
        public int age { get; set; }
        public long contactnumber { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string sportsname { get; set; }
    }
}
