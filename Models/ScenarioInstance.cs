using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace UEFASwissFormatSelector.Models
{
    public class ScenarioInstance: Identifiable
    {
        public Guid ScenarioId { get; set; }
        public virtual Scenario Scenario { get; set; }
        public virtual IEnumerable<Pot> Pots { get; set; }
        public virtual IEnumerable<ClubInScenarioInstance> ClubsInScenarioInstance { get; set; }
        [NotMapped]
        public virtual Dictionary<Guid, IEnumerable<Pot>>? Opponents { get; set; }
        [NotMapped]
        public virtual Dictionary<Guid, List<Club>>? MatchUps { get; set; }
        [NotMapped]
        public virtual Dictionary<Guid, List<String>>? MatchUpSkeleton { get; set; }
        public ScenarioInstance(Scenario scenario)
        {
            Scenario = scenario;
            ScenarioId = scenario.Id;
            Pots = new Pot[scenario.NumberOfPot];
            ClubsInScenarioInstance = new ClubInScenarioInstance[scenario.NumberOfPot * scenario.NumberOfTeamsPerPot];
        }
        /// <summary>
        /// To be used only for db purpose
        /// </summary>
        public ScenarioInstance()
        {
            
        }
    }
}
