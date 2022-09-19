using BEGames.Domain.Models;

namespace BEGames.Domain.IRepositories
{
    public interface IGameRepository
    {
        Task<List<Game>> GetListGames();
        Task<Game> AddGame(Game game);
        Task<Game> GetGame(int id);
        Task UpdateGame(Game game);
        Task DeleteGame(Game game);
    }
}
