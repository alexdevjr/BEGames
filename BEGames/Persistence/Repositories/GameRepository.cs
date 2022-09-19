using BEGames.Domain.IRepositories;
using BEGames.Domain.Models;
using BEGames.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace BEGames.Persistence.Repositories
{
    public class GameRepository: IGameRepository
    {
        private readonly ApplicationDbContext _context;

        public GameRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Game>> GetListGames()
        {
            return await _context.Game.ToListAsync();
        }

        public async Task<Game> AddGame(Game game)
        {
            game.CreatedAt = DateTime.Now;
            _context.Add(game);
            await _context.SaveChangesAsync();
            return game;
        }
        public async Task<Game> GetGame(int id)
        {
            return await _context.Game.FindAsync(id);
        }
        public async Task UpdateGame(Game game)
        {
            _context.Game.Update(game);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteGame(Game game)
        {
            _context.Game.Remove(game);
            await _context.SaveChangesAsync();
        }
    }
}
