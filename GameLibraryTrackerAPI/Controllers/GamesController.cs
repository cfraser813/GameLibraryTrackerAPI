using Microsoft.AspNetCore.Mvc;
using GameLibraryTrackerAPI.Data;
using GameLibraryTrackerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GameLibraryTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly GameLibraryTrackerAPIContext _context;

        public GamesController(GameLibraryTrackerAPIContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<Games>>GetGames()
        {
            //returns list of games as json
            return Ok(await _context.Game.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<Games>> AddGame(Games game)
        {
            if (game == null)
                return BadRequest();

            _context.Game.Add(game);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetGames), new { id = game.ID }, game);
        }
        [HttpDelete("{ID}")]
        public async Task<IActionResult> DeleteGame(int ID)
        {
            var game = await _context.Game.FindAsync(ID);
            if (game == null)
                return NotFound();

            _context.Game.Remove(game);

            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPut("{ID}")]
        public async Task<IActionResult> UpdateGame(int ID, Games updatedGame)
        {
            var game = await _context.Game.FindAsync(ID);
            if (game == null)
                return NotFound();

            game.ID = updatedGame.ID;
            game.Title = updatedGame.Title;
            game.Genre = updatedGame.Genre;
            game.ReleaseYear = updatedGame.ReleaseYear;

            await _context.SaveChangesAsync();

            return Ok(game);
        }    
    }
}
