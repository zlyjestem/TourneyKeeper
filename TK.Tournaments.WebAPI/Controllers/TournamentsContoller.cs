using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TK.Tournaments.WebAPI.Models;

namespace TourneyKeeper.Controllers
{
    [Route("api/tournaments")]
    
    public class TournamentsContoller : Controller
    {
        [HttpGet()]
        public IActionResult GetTournaments()
        {
            return Ok("Lorem ipsum");
        }

        [HttpGet("{id}")]
        public IActionResult GetTournament(int id)
        {
            var result = new TournamentDto();
            result.Id = id;
            result.Name = "Test tournament";
            return Ok(result);
        }
    }
}
