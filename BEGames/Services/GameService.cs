using BEGames.Domain.IRepositories;
using BEGames.Domain.IServices;
using BEGames.Domain.Models;

namespace BEGames.Services
{
    public class GameService: IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<List<Game>> GetListGames()
        {
            return await _gameRepository.GetListGames();
        }

        public async Task<Game> AddGame(Game game)
        {
            return await _gameRepository.AddGame(game);
        }

        public async Task<Game> GetGame(int id)
        {
            return await _gameRepository.GetGame(id);
        }

        public async Task UpdateGame(Game game)
        {
            await _gameRepository.UpdateGame(game);
        }
        public async Task DeleteGame(Game game)
        {
            await _gameRepository.DeleteGame(game);
        }
    }
}
