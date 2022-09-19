using BEGames.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BEGames.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Game> Game { get; set; }
    }
}
