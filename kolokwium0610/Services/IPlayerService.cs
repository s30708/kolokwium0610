using kolokwium0610.Models.DTOs;

namespace kolokwium0610.Services;

public interface IPlayerService
{
    Task<GetPlayerTournamentsDTO> GetPlayerTournaments(int playerId);
    Task AddPlayer(AddPlayerDTO addPlayerDTO);
}