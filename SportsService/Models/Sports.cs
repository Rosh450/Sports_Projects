using System.ComponentModel.DataAnnotations;

namespace SportsService.Models
{
    public class Sports
    {
        [Key]
        public int sportsid { get; set; }
        public int noofplayers { get; set; }
        public string sportsname { get; set; }
        public string sportstype { get; set; }
    }
}
