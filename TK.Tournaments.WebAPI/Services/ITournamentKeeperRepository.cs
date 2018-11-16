using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourneyKeeper.Entities;

namespace TK.Tournaments.WebAPI.Services
{
    public interface ITournamentKeeperRepository
    {
        IEnumerable<Tournament> GetTournaments();
        Tournament GeTournament(int Id);

    }
}
