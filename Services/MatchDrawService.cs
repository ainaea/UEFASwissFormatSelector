using System.Linq;
using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.Services
{
    public class MatchDrawService
    {
        public IEnumerable<Pot> PotTeam(ScenarioInstance scenarioInstance)
        {
            var scenario = scenarioInstance.Scenario;
            var clubsInScenarioInstance = scenarioInstance.ClubsInScenarioInstance;
            Pot[] pottedTeams = new Pot[scenario.NumberOfPot];
            clubsInScenarioInstance = clubsInScenarioInstance.OrderByDescending( c => c.Ranking).ToList();
            for (int i = 0; i < scenario.NumberOfPot; i++)
            {
                pottedTeams[i] = new Pot($"Pot {Enum.GetName(typeof(PotEnum), i) ?? i.ToString()}", scenario.NumberOfTeamsPerPot);
                var clubsInPot = clubsInScenarioInstance.Skip(i * scenario.NumberOfTeamsPerPot).Take(scenario.NumberOfTeamsPerPot).ToList();
                pottedTeams[i].ClubsInPot = clubsInPot.Select( c => new ClubInPot(c.ClubId, pottedTeams[i].Id) { Club = c.Club} );
            }
            return pottedTeams;
        }
    }
}
