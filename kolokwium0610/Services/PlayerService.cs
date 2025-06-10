using kolokwium0610.Data;
using kolokwium0610.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace kolokwium0610.Services;

public class PlayerService : IPlayerService
{
    
    private readonly DatabaseContext _context;
    
    public PlayerService(DatabaseContext context)
    {
        _context = context;
    }
    
    public async Task<GetPlayerTournamentsDTO?> GetPlayerTournaments(int playerId)
    {
        
        
        var player = await _context.Players
            .Where(p => p.PlayerId == playerId)
            .Select(p => new GetPlayerTournamentsDTO
            {
                PlayerId = p.PlayerId,
                FirstName = p.FirstName,
                LastName = p.LastName,
                BirthDate = p.BirthDate,
                Matches = p.Player_Matches.Select(pm => new MatchDTO
                {
                    Tournament = pm.Match.Tournament.Name,
                    Map = pm.Match.Map.Name,
                    Date = pm.Match.MatchDate,
                    MVPs = pm.MVPs,
                    Rating = pm.Rating,
                    Team1Score = pm.Match.Team1Score,
                    Team2Score = pm.Match.Team2Score
                }).ToList()
            }).FirstOrDefaultAsync();
        
        if(player == null)
            throw new Exception("Customer not found");

        return player;
    }

    public Task AddPlayer(AddPlayerDTO addPlayerDTO)
    {
        throw new NotImplementedException();
    }
}