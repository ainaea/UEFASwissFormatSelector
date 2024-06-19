using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.ViewModels
{
    public class ScenarioWithInstanceViewModel
    {
        public Scenario Scenario { get; set; }
        public IEnumerable<ScenarioInstance> ScenarioInstances { get; set; } = new List<ScenarioInstance>();
    }
}
