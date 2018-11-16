using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TK.Tournaments.WebAPI.Models
{
    public class TournamentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public float Price { get; set; }
        public string Currency { get; set; }
        public int SwissRounds { get; set; }
        public bool IfTopCut { get; set; }
        public int SizeOfTopCut { get; set; }
        public bool IfProgressiveCut { get; set; }
        public int WinsNeededForProgressiveCut { get; set; }
        public string Venue { get; set; }
        public string Adress { get; set; }
        public string StreamLink { get; set; }
        public string Description { get; set; }
    }
}
