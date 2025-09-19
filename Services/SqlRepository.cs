using Microsoft.EntityFrameworkCore;
using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.Services
{
    public class SqlRepository /*: IRepository*/
    {
        private readonly AppDbContext dbContext;
        private readonly DbSet<Club> clubs;
        private DbSet<Country> countries; 
        private readonly DbSet<Scenario> scenarios; 
        private readonly DbSet<ScenarioInstance> scenarioInstances;


        public SqlRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            clubs = dbContext.Clubs;
            countries = dbContext.Countries;
            scenarios = dbContext.Scenarios;
            scenarioInstances = dbContext.ScenarioInstances;
        }
        public IEnumerable<Club> Clubs { get => clubs; set { dbContext.SaveChanges(); } }
        public IEnumerable<Country> Countries
        {
            get => countries; 
            set
            {
                if (value != null)
                {
                    countries = value as DbSet<Country>; 
                    dbContext.SaveChanges();
                }
            }
        } 
        public IEnumerable<Scenario> Scenarios { get => scenarios; set { dbContext.SaveChanges(); } }
        public IEnumerable<ScenarioInstance> ScenarioInstances { get => scenarioInstances; set { dbContext.SaveChanges(); } }
    }
}
