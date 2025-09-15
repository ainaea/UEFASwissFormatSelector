using Microsoft.EntityFrameworkCore;
using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.Services
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Pot> Pots { get; set; }
        public DbSet<ClubInPot> ClubsInPot { get; set; }
        public DbSet<ClubInScenarioInstance> ClubsInScenarioInstance { get; set; }
        public DbSet<Scenario> Scenarios { get; set; }
        public DbSet<ScenarioInstance> ScenarioInstances { get; set; }

    }
}
