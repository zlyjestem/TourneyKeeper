using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourneyKeeper.Entities;

namespace TK.Tournaments.WebAPI.Entities
{
    public class TourneyKeeperContext : DbContext
    {
        public TourneyKeeperContext(DbContextOptions<TourneyKeeperContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<Tournament> Tournaments { get; set; }
    }
}
