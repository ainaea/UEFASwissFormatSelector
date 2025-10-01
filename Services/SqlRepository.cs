using Microsoft.EntityFrameworkCore;
using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.Services
{
    public class SqlRepository : IRepository
    {
        private readonly AppDbContext dbContext;
        private readonly SqlUnitRepository<Club> clubs;
        private readonly SqlUnitRepository<Country> countries; 
        private readonly SqlUnitRepository<Scenario> scenarios; 
        private readonly SqlUnitRepository<ScenarioInstance> scenarioInstances;


        public SqlRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            clubs = new SqlUnitRepository<Club>(dbContext);
            countries = new SqlUnitRepository<Country>(dbContext);
            scenarios = new SqlUnitRepository<Scenario>(dbContext);
            scenarioInstances = new SqlUnitRepository<ScenarioInstance>(dbContext)/*.Include(si => si.Scenario)*/;
        }
        public IUnitRepository<Club> Clubs { get => clubs; set { } }
        public IUnitRepository<Country> Countries { get => countries; set { } } 
        public IUnitRepository<Scenario> Scenarios { get => scenarios; set { } }
        public IUnitRepository<ScenarioInstance> ScenarioInstances { get => IncludeCountries(); set { } }

        private IUnitRepository<ScenarioInstance> IncludeCountries()
        {
            var sis = scenarioInstances;
            foreach (var si in sis)
            {
                if (si.Scenario == null)
                {
                    si.Scenario = GetScenario(si.ScenarioId);
                }
            }
            return sis;
        }

        private Scenario? GetScenario(Guid id)
        {
            return Scenarios.Find(id);
        }
        public void Add<T>(List<T> entities) where T: class
        {
            try
            {
                var dbset = dbContext.Set<T>();
                if (dbset != null)
                {
                    foreach (var entity in entities)
                        dbset.Add(entity);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
