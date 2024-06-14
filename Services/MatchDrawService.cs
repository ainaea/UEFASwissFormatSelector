using System.Collections.Generic;
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
                pottedTeams[i] = new Pot(GeneratePotName(i), scenario.NumberOfTeamsPerPot);
                var clubsInPot = clubsInScenarioInstance.Skip(i * scenario.NumberOfTeamsPerPot).Take(scenario.NumberOfTeamsPerPot).ToList();
                pottedTeams[i].ClubsInPot = clubsInPot.Select( c => new ClubInPot(c.ClubId, pottedTeams[i].Id) { Club = c.Club} );
            }
            return pottedTeams;
        }
        private string GeneratePotName(int i) => $"Pot {Enum.GetName(typeof(PotEnum), i) ?? i.ToString()}";

        public IEnumerable<Pot> GenerateOpponentsForClub(ScenarioInstance scenarioInstance, Club club)
        {
            Pot[] possibleOpponents = new Pot[scenarioInstance.Scenario.NumberOfPot];
            foreach (Pot pot in scenarioInstance.Pots)
            {
                var opponentsFromPot = new Pot(pot.Name, pot.ClubsInPot.Count());
                opponentsFromPot.ClubsInPot = pot.ClubsInPot.Where( cp => cp.ClubId != club.Id && cp.Club?.CountryId != club.CountryId );
                possibleOpponents.Append(opponentsFromPot);
            }
            return possibleOpponents;
        }

        public Dictionary<Guid, IEnumerable<Pot>> GenerateOpponentsForAllClubs(ScenarioInstance scenarioInstance)
        {
            Dictionary<Guid, IEnumerable<Pot>> allPossibleOpponents = new Dictionary<Guid, IEnumerable<Pot>>();
            foreach (ClubInScenarioInstance club in scenarioInstance.ClubsInScenarioInstance)
            {
                allPossibleOpponents[club.ClubId] = GenerateOpponentsForClub(scenarioInstance, club.Club!);
            }
            return allPossibleOpponents;
        }

        public IEnumerable<Club> PickOpponents(int numberOfOpponents, IEnumerable<Club> from)
        {
            var opponents = new Club[numberOfOpponents];
            if (from != null || numberOfOpponents > from!.Count())
                return opponents;
            var random = new Random();
            for (int i = 0; i < numberOfOpponents; i++)
            {
                int choiceIndex = random.Next(0, from!.Count());
                opponents.Append(from!.ToList()[choiceIndex]);
                from!.ToList().Remove(from!.ToList()[choiceIndex]);
            }
            return opponents;
        }
        //private Dictionary<Guid, IEnumerable<Pot>>? opponents;
        //public Dictionary<Guid, Club[]> FixMatches(IEnumerable<Club> opponents, Club club, Dictionary<Guid, Club[]> matchLineUp)
        //{
        //    foreach (Club opponent in opponents)
        //    {
        //        matchLineUp[club.Id].Append(opponent);
        //        matchLineUp[opponent.Id][Array.IndexOf(matchLineUp[club.Id], opponent)] = club;
        //    }
        //    //also adjust possible opponents
        //    return matchLineUp!;
        //}

        public int RemoveFromPossibleOpponents()
        {
            return default(int);
        }
    }
}
