using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
            return Ok(id.ToString());
        }
    }
}
