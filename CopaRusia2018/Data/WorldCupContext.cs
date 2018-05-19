using CopaRusia2018.Models;
using Microsoft.EntityFrameworkCore;


namespace CopaRusia2018.Data
{
    public class WorldCupContext: DbContext
    {
        public WorldCupContext(DbContextOptions<WorldCupContext> options): base(options)
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Country> Countries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().ToTable("Player");
            modelBuilder.Entity<Country>().ToTable("Country");
        }

    }
}
