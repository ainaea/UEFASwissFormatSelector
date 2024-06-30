namespace UEFASwissFormatSelector.Models
{
    public class ScenarioInstance: Identifiable
    {
        public Guid ScenarioId { get; set; }
        public virtual Scenario Scenario { get; set; }
        public virtual IEnumerable<Pot> Pots { get; set; }
        public virtual IEnumerable<ClubInScenarioInstance> ClubsInScenarioInstance { get; set; }
        public Dictionary<Guid, IEnumerable<Pot>>? Opponents { get; set; }
        public Dictionary<Guid, List<Club>>? MatchUps { get; set; }
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
