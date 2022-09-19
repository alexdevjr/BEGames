using BEGames.Domain.IServices;
using BEGames.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BEGames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<IActionResult> GetGames()
        {
            try
            {
                var listGames = await _gameService.GetListGames();

                return Ok(listGames);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Game game)
        {
            try
            {
                var saveGame = await _gameService.AddGame(game);

                return Ok(saveGame);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var game = await _gameService.GetGame(id);

                if (game == null)
                {
                    return NotFound();
                }

                return Ok(game);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Game game)
        {
            try
            {
                if (id != game.Id)
                {
                    return BadRequest();
                }

                await _gameService.UpdateGame(game);
                return Ok(new { message = "Juego actualizado con éxito!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var game = await _gameService.GetGame(id);

                if (game == null)
                {
                    return NotFound();
                }

                await _gameService.DeleteGame(game);
                return Ok(new { message = "Juego eliminado con éxito!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
