using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TourneyKeeper.Entities
{
    public class Tournament
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public float Price { get; set; }
        public int SwissRounds { get; set; }
        public bool IfTopCut { get; set; }
        public bool IfProgressiveCut { get; set; }
        public string Venue { get; set; }
        public string Adress { get; set; }
    }
}
