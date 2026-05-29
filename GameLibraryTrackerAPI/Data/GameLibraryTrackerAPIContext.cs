using GameLibraryTrackerAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace GameLibraryTrackerAPI.Data
{
    public class GameLibraryTrackerAPIContext : DbContext
    {
        public GameLibraryTrackerAPIContext(DbContextOptions<GameLibraryTrackerAPIContext> options) : base(options) { }
        public DbSet<Games> Game { get; set; } = null!;
    }
}
