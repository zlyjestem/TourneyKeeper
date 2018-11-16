using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TK.Tournaments.WebAPI.Models;
using TK.Tournaments.WebAPI.Services;

namespace TourneyKeeper.Controllers
{
    [Route("api/tournaments")]
    
    public class TournamentsContoller : Controller
    {
        private ITournamentKeeperRepository _tournamentKeeperRepository;

        public TournamentsContoller(ITournamentKeeperRepository tournamentKeeperRepository)
        {
            _tournamentKeeperRepository = tournamentKeeperRepository;
        }
        [HttpGet()]
        public IActionResult GetTournaments()
        {
            var tournamentEntities = _tournamentKeeperRepository.GetTournaments();
            var results = AutoMapper.Mapper.Map<IEnumerable<TournamentDto>>(tournamentEntities);
            return Ok(results);
        }

        [HttpGet("{id}")]
        public IActionResult GetTournament(int id)
        {
            var tournamentEntity = _tournamentKeeperRepository.GeTournament(id);
            if (tournamentEntity == null)
            {
                return NotFound();
            }

            var result = AutoMapper.Mapper.Map<TournamentDto>(tournamentEntity);
            return Ok(result);
        }
    }
}
