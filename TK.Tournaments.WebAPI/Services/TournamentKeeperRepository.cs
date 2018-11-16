﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TK.Tournaments.WebAPI.Entities;
using TourneyKeeper.Entities;

namespace TK.Tournaments.WebAPI.Services
{
    public class TournamentKeeperRepository : ITournamentKeeperRepository
    {
        private TourneyKeeperContext _context;

        public TournamentKeeperRepository(TourneyKeeperContext context)
        {
            _context = context;
        }

        public IEnumerable<Tournament> GetTournaments()
        {
            return _context.Tournaments.OrderBy(t => t.StartDateTime).ToList();
        }

        public Tournament GeTournament(int Id)
        {
            return _context.Tournaments.FirstOrDefault(t => t.Id == Id);
        }
    }
}
