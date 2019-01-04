using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TK.Tournaments.WebAPI.Models
{
    public class TournamentSummaryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public float Price { get; set; }
        public string Currency { get; set; }
        public string Venue { get; set; }
        public string Adress { get; set; }
        public string Format { get; set; }
        
    }
}
