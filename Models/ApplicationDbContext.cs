using Microsoft.EntityFrameworkCore;

namespace GeoSight.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<ClientStat> ClientStats { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Sight> Sights { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameRound> GameRounds { get; set; }
        public DbSet<AdminAction> AdminActions { get; set; }
    }
}
