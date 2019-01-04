using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using TK.Tournaments.WebAPI.Models;
using TK.Tournaments.WebAPI.Services;
using TourneyKeeper.Entities;

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
            var results = Mapper.Map<IEnumerable<TournamentSummaryDto>>(tournamentEntities);
            return Ok(results);
        }

        [HttpGet("{id}", Name = "GetTournament")]
        public IActionResult GetTournament(int id)
        {
            var tournamentEntity = _tournamentKeeperRepository.GeTournament(id);
            if (tournamentEntity == null) return NotFound();

            var result = Mapper.Map<TournamentDto>(tournamentEntity);
            return Ok(result);
        }

        [HttpPost()]
        public IActionResult AddTournament([FromBody] TournamentForCreationDto tournament)
        {
            if (tournament == null) return BadRequest();
            var incomingTournament = Mapper.Map<Tournament>(tournament);
            _tournamentKeeperRepository.AddTournament(incomingTournament);

            if (!_tournamentKeeperRepository.Save())
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }

            var createdTournament = Mapper.Map<TournamentDto>(incomingTournament);

            return CreatedAtRoute("GetTournament", new
                { id = createdTournament.Id }, createdTournament);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTournament(int id, [FromBody] TournamentForUpdateDto tournament)
        {
            if (tournament == null) return BadRequest();

            var tournamentForUpdate = _tournamentKeeperRepository.GeTournament(id);
            if (tournamentForUpdate == null) return NotFound();
            
            Mapper.Map(tournament, tournamentForUpdate);
            if (!_tournamentKeeperRepository.Save())
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }

            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PartiallyUpdateTournament(int id, [FromBody] JsonPatchDocument<TournamentForUpdateDto> docPatch)
        {
            if (docPatch == null) return BadRequest();

            var tournamentForUpdate = _tournamentKeeperRepository.GeTournament(id);
            if (tournamentForUpdate == null) return NotFound();

            var tournamentToPatch = Mapper.Map<TournamentForUpdateDto>(tournamentForUpdate);
            docPatch.ApplyTo(tournamentToPatch, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            TryValidateModel(tournamentToPatch);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Mapper.Map(tournamentToPatch, tournamentForUpdate);
            if (!_tournamentKeeperRepository.Save())
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }

            return NoContent();

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTournament(int id)
        {
            
            var tournamentToDelete = _tournamentKeeperRepository.GeTournament(id);
            if (tournamentToDelete == null) return NotFound();
            
            _tournamentKeeperRepository.DeleteTournament(tournamentToDelete);
            if (!_tournamentKeeperRepository.Save())
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }

            return NoContent();
        }
    }
}
