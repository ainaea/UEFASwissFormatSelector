namespace UEFASwissFormatSelector.Models
{
    public class ClubInScenarioInstance
    {
        public Guid ClubId { get; set; }
        public Guid ScenarioInstanceId { get; set; }
        public virtual Club? Club { get; set; }
        public virtual ScenarioInstance? ScenarioInstance { get; set; }
        public ClubInScenarioInstance(Guid clubId, Guid scenarioInstanceId)
        {
            ClubId = clubId;
            ScenarioInstanceId = scenarioInstanceId;
        }
    }
}
