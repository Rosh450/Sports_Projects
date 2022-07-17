using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParticipationApi.Models
{
    public class Participations
    {
        public int ParticipationId { get; set; }
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int EventId { get; set; }
         public string EventName { get; set; }
        public int SportsId { get; set; }
        public string SportsName { get; set; }
        public string Status { get; set; }

    }
}