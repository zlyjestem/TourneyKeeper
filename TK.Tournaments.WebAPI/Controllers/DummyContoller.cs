using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TK.Tournaments.WebAPI.Entities;

namespace TK.Tournaments.WebAPI.Controllers
{
    public class DummyContoller : Controller
    {
        private TourneyKeeperContext _ctx;

        public DummyContoller(TourneyKeeperContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        [Route("api/testdatabase")]
        public IActionResult TestDatabse()
        {
            return Ok();
        }
    }
}
