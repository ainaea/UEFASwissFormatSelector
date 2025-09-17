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
        public DbSet<Scenario> Scenarios { get; set; }
        public DbSet<ScenarioInstance> ScenarioInstances { get; set; }
        public DbSet<ClubInScenarioInstance> ClubsInScenarioInstance { get; set; }

        public DbSet<Pot> Pots { get; set; }
        public DbSet<ClubInPot> ClubsInPot { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<ClubInPot>(cip => cip.HasNoKey() );
            //modelBuilder.Entity<ClubInPot>()
            //    .HasOne(cip => cip.Pot)
            //    .WithMany(p => p.ClubsInPot)
            //    .HasForeignKey(cip => cip.PotId);

            modelBuilder.SeedDBData();

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany( t => t.GetForeignKeys() ))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<ClubInPot>(Cips =>
            {
                //cip.HasNoKey()
                Cips.HasKey(c => new { c.ClubId, c.PotId });
                Cips.HasOne(cip => cip.Pot)
                .WithMany(p => p.ClubsInPot)
                .HasForeignKey(cip => cip.PotId);

            });


            modelBuilder.Entity<ClubInScenarioInstance>(Cisis =>
            {
                Cisis.HasKey( cisi=> new {cisi.ClubId, cisi.ScenarioInstanceId});
                Cisis.HasOne(c => c.ScenarioInstance)
                .WithMany(si => si.ClubsInScenarioInstance)
                .HasForeignKey(cisi => cisi.ScenarioInstanceId);
            });
        }

    }
}
