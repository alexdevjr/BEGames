using BEGames.Domain.Models;

namespace BEGames.Domain.IServices
{
    public interface IGameService
    {
        Task<List<Game>> GetListGames();
        Task<Game> AddGame(Game game);
        Task<Game> GetGame(int id);
        Task UpdateGame(Game game);
        Task DeleteGame(Game game);
    }
}
