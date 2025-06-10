using kolokwium0610.Models.DTOs;
using kolokwium0610.Services;
using Microsoft.AspNetCore.Mvc;

namespace kolokwium0610.Controllers;

[ApiController]
[Route("api/players")]
public class PlayersController : ControllerBase
{
    private readonly IPlayerService _playerService;

    public PlayersController(IPlayerService playerService)
    {
        _playerService = playerService;
    }

    [HttpGet("{id}/matches")]
    public async Task<IActionResult> GetMatches(int id)
    {
        var playerData = await _playerService.GetPlayerTournaments(id);
        if (playerData == null)
            return NotFound($"Player with id {id} not found.");

        return Ok(playerData);
    }

    [HttpPost]
    public async Task<IActionResult> AddPlayer([FromBody] AddPlayerDTO addPlayerDto)
    {
        throw new NotImplementedException();
    }
    
}
