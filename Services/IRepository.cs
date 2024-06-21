using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.Services
{
    public interface IRepository
    {
        IEnumerable<Club> Clubs { get; set; }
        IEnumerable<Country> Countries { get; set; }
        IEnumerable<Scenario> Scenarios { get; set; }
        IEnumerable<ScenarioInstance> ScenarioInstances { get; set; }
    }
}
