using System.ComponentModel.DataAnnotations;

namespace EventsServices.Models
{
    public class Events
    {
        [Key]
        public int eventid { get; set; }
        public string eventdate { get; set; }
        public string eventname { get; set; }
        public int noofslots { get; set; }
        public string sportsname { get; set; }
    }
}
