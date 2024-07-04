using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.Services
{
    public class MatchDrawService: IMatchDrawService
    {
        public MatchDrawService()
        {
            //allOpponents = new Dictionary<Guid, IEnumerable<Pot>>();
        }
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
                pottedTeams[i].ClubsInPot = clubsInPot.Select( c => new ClubInPot(c.ClubId, pottedTeams[i].Id) { Club = c.Club} ).ToList();
                pottedTeams[i].ScenarioInstanceId = scenarioInstance.Id;
            }
            return pottedTeams;
        }
        private string GeneratePotName(int i) => $"Pot {Enum.GetName(typeof(PotEnum), i) ?? i.ToString()}";

        public IEnumerable<Pot> GenerateOpponentsForClub(ScenarioInstance scenarioInstance, Club club)
        {
            List<Pot> possibleOpponents = new List<Pot>();
            foreach (Pot pot in scenarioInstance.Pots)
            {
                var opponentsFromPot = new Pot(pot.Name, pot.ClubsInPot.Count()) { ScenarioInstanceId = scenarioInstance.Id};
                opponentsFromPot.ClubsInPot = pot.ClubsInPot.Where( cp => cp.ClubId != club.Id && cp.Club?.CountryId != club.CountryId ).ToList();
                possibleOpponents.Add(opponentsFromPot);
            }
            return possibleOpponents;
        }

        public Dictionary<Guid, IEnumerable<Pot>> GenerateOpponentsForAllClubs(ScenarioInstance scenarioInstance)
        {
            Dictionary<Guid, IEnumerable<Pot>> allOpponents = new Dictionary<Guid, IEnumerable<Pot>>();
            //Dictionary<Guid, IEnumerable<Pot>> allPossibleOpponents = new Dictionary<Guid, IEnumerable<Pot>>();
            foreach (ClubInScenarioInstance club in scenarioInstance.ClubsInScenarioInstance)
            {
                allOpponents[club.ClubId] = GenerateOpponentsForClub(scenarioInstance, club.Club!);
            }
            return allOpponents;
        }

        public IEnumerable<Club> PickOpponents(int numberOfOpponents, IEnumerable<Club> from)
        {
            var opponents = new List<Club>();
            if (from == null)
                return opponents;
            if (numberOfOpponents >= from!.Count())
                return from;
            var random = new Random();
            for (int i = 0; i < numberOfOpponents; i++)
            {
                int choiceIndex = random.Next(0, from!.Count());
                opponents.Add(from!.ToList()[choiceIndex]);
                var newFrom = from!.ToList();
                newFrom.Remove(from!.ToList()[choiceIndex]);
                from = newFrom;
            }
            return opponents;
        }
        //private Dictionary<Guid, IEnumerable<Pot>> allOpponents;  //Dictionary<Guid clubId, IEnumerable<Pot>>?  //allPossibleOpponents
        public Dictionary<Guid, Club[]> FixMatches(IEnumerable<Club> opponents, Club club, Dictionary<Guid, Club[]> matchLineUp, Dictionary<Guid, IEnumerable<Pot>> allOpponents)
        {
            foreach (Club opponent in opponents)
            {
                matchLineUp[club.Id].Append(opponent);
                matchLineUp[opponent.Id][Array.IndexOf(matchLineUp[club.Id], opponent)] = club;
            }
            RemoveFromPossibleOpponents(opponents, club, allOpponents);
            return matchLineUp!;
        }

        public void RemoveFromPossibleOpponents(IEnumerable<Club> opponents, Club club, Dictionary<Guid, IEnumerable<Pot>> allOpponents)
        {
            foreach(Club opponent in opponents)
            {
                var clubInPot = allOpponents[opponent.Id].FirstOrDefault(p => p.ClubsInPot.Any(cp => cp.ClubId == club.Id))?.ClubsInPot.ToList().FirstOrDefault(cp => cp.ClubId == club.Id);
                allOpponents[opponent.Id].FirstOrDefault(p => p.ClubsInPot.Any(cp => cp.ClubId == club.Id))?.ClubsInPot.ToList().Remove(clubInPot!);

                var opponentInPot = allOpponents[club.Id].FirstOrDefault(p => p.ClubsInPot.Any(cp => cp.ClubId == opponent.Id))?.ClubsInPot.ToList().FirstOrDefault(cp => cp.ClubId == opponent.Id);
                allOpponents[club.Id].FirstOrDefault(p => p.ClubsInPot.Any(cp => cp.ClubId == opponent.Id))?.ClubsInPot.ToList().Remove(opponentInPot!);
            }
        }
        //testing
        private List<Club> FindOpponents(int numberOfOpponent, Guid forClubId, List<Club> preferredOppponents, List<Club> allPot)
        {
            if(numberOfOpponent == preferredOppponents.Count())
            {
                return preferredOppponents;
            }
            else if (numberOfOpponent < preferredOppponents.Count())
            {
                return PickOpponents(numberOfOpponent, preferredOppponents).ToList();
            }
            else
            {
                //means number of preferredOppponents is not enough
                int remainderOppponents = numberOfOpponent - preferredOppponents.Count();
                var unselectedClubs = allPot.Where( c => c.Id != forClubId && !preferredOppponents.Contains(c)).ToList();
                var remainder = PickOpponents(remainderOppponents, unselectedClubs);
                preferredOppponents.AddRange(remainder);
                return preferredOppponents;
            }

        }
        public Dictionary<Guid, List<Club>> DoMatchUps(ScenarioInstance scenarioInstance, int numberOfOpponentPerPot)
        {
            Dictionary<Guid, List<string>> fixedMatches = new Dictionary<Guid, List<string>>();     //Guid is for clubId and string is the concatination of format "cludib_potname"
            Dictionary<Guid, List<Club>> fixedMatchesFull = new Dictionary<Guid, List<Club>>();
            //initialize a club keys
            foreach ( Club club in scenarioInstance.ClubsInScenarioInstance.Select( c=> c.Club).ToList())
            {
                fixedMatches[club!.Id] = new List<string>();
                fixedMatchesFull[club.Id] = new List<Club>();
            }
            int expectedMatchCount = scenarioInstance.Pots.Count() * numberOfOpponentPerPot;
            List<String> potNames = scenarioInstance.Pots.Select(p => p.Name).ToList();
            if (scenarioInstance.Opponents != null)
            {
                for (int i = 0; i <= numberOfOpponentPerPot; i++)        //just for ensuring matchup starts with club-pot with zero natural opponents upward
                {
                    foreach (KeyValuePair<Guid, IEnumerable<Pot>> clubDictionary in scenarioInstance.Opponents.Where(opp => opp.Value.Any(p => p.ClubsInPot.Count() == i)).ToList())
                    {
                        //say clubDictionary reprents Man City dictionary, 
                        Club thisClub = scenarioInstance.ClubsInScenarioInstance.FirstOrDefault(c => c.ClubId == clubDictionary.Key)?.Club!;
                        string clubPotName = GetClubPotName(thisClub.Id, scenarioInstance.Pots);
                        foreach (var oppositionPot in clubDictionary.Value.Where(p => p.ClubsInPot.Count() == i))
                        {
                            int remainingOpponents = numberOfOpponentPerPot - FoundedOpponentsInPot(oppositionPot.Name, thisClub.Id, fixedMatches);
                            if (remainingOpponents <= 0)
                                continue;

                            //oppositionPot is a pot that contains exactly i opponents for Man City

                            //Get exactly numberOfOpponentPerPot number of opponents eg 4 to face Mancity club in clubdictionary
                            //1. remove possible opponents clubs that have maxed out
                            var preferredOppoents = oppositionPot.ClubsInPot.Where(cip => !ClubPotFixtureFull(cip.ClubId, clubPotName, fixedMatches, numberOfOpponentPerPot)).Select(cip => cip.Club).ToList();
                            //2. remove pot clubs that have maxed out
                            var allPot = GetPotByName(oppositionPot.Name, scenarioInstance.Pots)!.ClubsInPot.Where(cip => !ClubPotFixtureFull(cip.ClubId, clubPotName, fixedMatches, numberOfOpponentPerPot)).Select(cip => cip.Club).ToList();
                            //3. call method to choose opponents
                            var opponentsForClub = FindOpponents(remainingOpponents, thisClub.Id, preferredOppoents!, allPot!);
                            //4. fixup opponents
                            if (opponentsForClub != null)
                            {
                                foreach (Club opponent in opponentsForClub)
                                {
                                    fixedMatches[thisClub.Id].Add(GenerateClubPotName(opponent.Id, oppositionPot.Name));
                                    fixedMatches[opponent.Id].Add(GenerateClubPotName(thisClub.Id, clubPotName));
                                    //fixedMatchesFull[thisClub.Id].Add(opponent);
                                    //fixedMatchesFull[opponent.Id].Add(thisClub);
                                }
                            }
                        }

                    }
                }
                if (fixedMatches.Any(kvp => kvp.Value.Count() < expectedMatchCount))
                {
                    foreach (var kvp in fixedMatches)
                    {                        
                        if (kvp.Value.Count < expectedMatchCount)
                        {
                            Guid clubId = kvp.Key;
                            Club thisClub = scenarioInstance.ClubsInScenarioInstance.FirstOrDefault(c => c.ClubId == clubId)?.Club!;
                            string clubPotName = GetClubPotName(thisClub.Id, scenarioInstance.Pots);
                            foreach (String potName in potNames)
                            {
                                if (kvp.Value.Count >= expectedMatchCount)
                                    break;
                                //string dd;
                                //if (potName == "Pot C")
                                //    dd = clubId.ToString();
                                int clubPotCount = ClubPotFixtureCount(clubId, potName, fixedMatches);
                                if (clubPotCount < numberOfOpponentPerPot)
                                {
                                    var allFreePotCLubs = GetPotByName(potName, scenarioInstance.Pots)!.ClubsInPot.Where(cip =>cip.Club?.CountryId != thisClub.CountryId && !ClubPotFixtureFull(cip.ClubId, clubPotName, fixedMatches, numberOfOpponentPerPot)).Select(cip => cip.Club).Where( c => !ClubHasFixtureAgainst(c!.Id, clubId, fixedMatches)).ToList();
                                    var opponentsForClub = FindOpponents(numberOfOpponentPerPot - clubPotCount, thisClub.Id, new List<Club>(), allFreePotCLubs!);

                                    if (opponentsForClub != null)
                                    {
                                        foreach (Club opponent in opponentsForClub)
                                        {
                                            fixedMatches[thisClub.Id].Add(GenerateClubPotName(opponent.Id, potName));
                                            fixedMatches[opponent.Id].Add(GenerateClubPotName(thisClub.Id, clubPotName));
                                            //fixedMatchesFull[thisClub.Id].Add(opponent);
                                            //fixedMatchesFull[opponent.Id].Add(thisClub);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (fixedMatches.Any(kvp => kvp.Value.Count < expectedMatchCount))
            {
                foreach(var kvp in fixedMatches.Where(matches => matches.Value.Count < expectedMatchCount ))
                {
                    string kvpPot = GetClubPotName(kvp.Key, scenarioInstance.Pots);
                    var kvpCLub = scenarioInstance.ClubsInScenarioInstance.First(cisi => cisi.Club?.Id == kvp.Key).Club;
                    if (kvp.Value.Count >= expectedMatchCount)
                        break;
                    var otherClubsInKVPot = GetPotByName(kvpPot, scenarioInstance.Pots)?.ClubsInPot.Where(cip=> cip.Club?.Id!= kvp.Key).Select(cip => cip.Club).ToList();
                    foreach (String potName in potNames)
                    {
                        if (!ClubPotFixtureFull(kvp.Key, potName, fixedMatches, numberOfOpponentPerPot))
                        {
                            int remainingOpponents = numberOfOpponentPerPot - ClubPotFixtureCount(kvp.Key, potName, fixedMatches);
                            if (remainingOpponents <= 0)
                                continue;
                            var possibleOpponentsFromPot = GetPotByName(potName, scenarioInstance.Pots)?.ClubsInPot.Select(c => c.Club).Where( c=> c!.Id != kvp.Key && !ClubHasFixtureAgainst(kvp.Key, c.Id, fixedMatches)).ToList();
                            //All clubs returned above must have been maxed out by other clubs henece why they were not chosen before here. So replacement will have to be done.
                            var selectedOpponents = FindOpponents(remainingOpponents, kvp.Key, possibleOpponentsFromPot?.Where(c => c?.CountryId != kvpCLub?.CountryId)!.ToList<Club>() ?? new List<Club>(), possibleOpponentsFromPot?.ToList()!);
                            foreach (var selectedOpponent in selectedOpponents)
                            {
                                var clubsInKVPotPlayingOpponet = otherClubsInKVPot?.Where(c => ClubHasFixtureAgainst(c!.Id, selectedOpponent.Id, fixedMatches)).ToList();
                                if (clubsInKVPotPlayingOpponet.Count > 0)
                                {
                                    //select one of the clubs in kvp pot to swap opponent with
                                    var selectedPotClubPlayingOpponent = FindOpponents(1, kvp.Key, clubsInKVPotPlayingOpponet?.Where(c => c?.CountryId != kvpCLub?.CountryId)!.ToList<Club>() ?? new List<Club>(), clubsInKVPotPlayingOpponet!.ToList<Club>()!).First();
                                    var clubsWithIncompleteFixturesInOppositionPot = GetPotByName(potName, scenarioInstance.Pots)?.ClubsInPot.Select(c => c.Club).Where(c => c!.Id != kvp.Key && !ClubPotFixtureFull(c!.Id, kvpPot, fixedMatches, numberOfOpponentPerPot))?.ToList();
                                    if (clubsWithIncompleteFixturesInOppositionPot != null && clubsWithIncompleteFixturesInOppositionPot.Count > 0)
                                    {
                                        var selectedCWIFIO = FindOpponents(1, kvp.Key, new List<Club>(), clubsWithIncompleteFixturesInOppositionPot!).First();
                                        fixedMatches[selectedCWIFIO.Id].Add(GenerateClubPotName(selectedPotClubPlayingOpponent.Id, kvpPot));
                                        fixedMatches[kvp.Key].Add(GenerateClubPotName(selectedOpponent.Id, potName));

                                        //fixedMatches[selectedOpponent.Id].FirstOrDefault(kv => kv == GenerateClubPotName(selectedPotClubPlayingOpponent.Id, kvpPot));// = GenerateClubPotName(kvp.Id, kvpPot);
                                        var aValue = fixedMatches[selectedOpponent.Id];
                                        int aIndex = aValue.IndexOf(aValue.FirstOrDefault(kv => kv == GenerateClubPotName(selectedPotClubPlayingOpponent.Id, kvpPot))!);
                                        aValue[aIndex] = GenerateClubPotName(kvp.Key, kvpPot);

                                        //fixedMatches[selectedPotClubPlayingOpponent.Id].FirstOrDefault(kv => kv == GenerateClubPotName(selectedOpponent.Id, potName));// = GenerateClubPotName(selectedCWIFIO.Id, potName);

                                        var bValue = fixedMatches[selectedPotClubPlayingOpponent.Id];
                                        int bIndex = bValue.IndexOf(bValue.FirstOrDefault(kv => kv == GenerateClubPotName(selectedOpponent.Id, potName))!);
                                        bValue[bIndex] = GenerateClubPotName(selectedCWIFIO.Id, potName);

                                        bool lazioFull = ClubPotFixtureFull(selectedCWIFIO.Id, kvpPot, fixedMatches, 2);

                                        //var listClub = new List<Club>
                                        //{
                                        //    selectedCWIFIO, //rmd
                                        //    selectedOpponent,   //mnc
                                        //    selectedPotClubPlayingOpponent, //juv
                                        //    //kvp as club acm
                                        //};
                                        if (fixedMatches.Any(kvp => kvp.Value.Count > expectedMatchCount))
                                        {
                                            var abnormals = fixedMatches.Where(kvp => kvp.Value.Count > expectedMatchCount).ToList();
                                        }
                                        if (kvp.Value.Count >= expectedMatchCount)
                                            break;
                                    }
                                    else if (remainingOpponents % 2 == 0 && kvpPot == potName)
                                    {
                                        int neededPairs = remainingOpponents / 2;
                                        var clubsWithCompleteFixturesInOppositionPot = GetPotByName(potName, scenarioInstance.Pots)?.ClubsInPot.Select(c => c.Club).Where(c => c!.Id != kvp.Key && c?.CountryId != kvpCLub?.CountryId && !ClubHasFixtureAgainst(kvp.Key, c!.Id, fixedMatches) && ClubPotFixtureFull(c!.Id, kvpPot, fixedMatches, numberOfOpponentPerPot))?.ToList();
                                        var cWCFIOPIds = clubsWithCompleteFixturesInOppositionPot?.Select(c => c!.Id).ToList();
                                        List<Guid> swapUpOpponents = new List<Guid>();
                                        foreach (var club in clubsWithCompleteFixturesInOppositionPot!)
                                        {
                                            bool clubPlayingPlayableOpponent = fixedMatches[club!.Id].Any(clubId_pot => cWCFIOPIds!.Contains(ExtractClubId_Club_PotName(clubId_pot)) && /*GetClub(clubId_pot, scenarioInstance.ClubsInScenarioInstance).CountryId != kvpCLub!.CountryId &&*/ !swapUpOpponents.Contains(ExtractClubId_Club_PotName(clubId_pot)));
                                            //club already has a match with another playable opponents kvpCLub                                        
                                            if (clubPlayingPlayableOpponent)
                                            {
                                                List<Club> suitableClubs = fixedMatches[club!.Id].Where(clubId_pot => cWCFIOPIds!.Contains(ExtractClubId_Club_PotName(clubId_pot)) && !swapUpOpponents.Contains(ExtractClubId_Club_PotName(clubId_pot))).Select(clubId_pot => GetClub(clubId_pot, scenarioInstance.ClubsInScenarioInstance)).ToList();
                                                swapUpOpponents.Add(club.Id);
                                                //add club fixture for kvp
                                                fixedMatches[kvp.Key].Add(GenerateClubPotName(club!.Id, potName));
                                                foreach (var suitableClub in suitableClubs)
                                                {
                                                    swapUpOpponents.Add(suitableClub.Id);

                                                    //add suitableClub fixture for kvp
                                                    fixedMatches[kvp.Key].Add(GenerateClubPotName(suitableClub!.Id, potName));
                                                    //replace club with kvp in suitableClub fixture
                                                    var aValue = fixedMatches[suitableClub.Id];
                                                    int aIndex = aValue.IndexOf(aValue.FirstOrDefault(kv => kv == GenerateClubPotName(club.Id, potName))!);
                                                    aValue[aIndex] = GenerateClubPotName(kvp.Key, kvpPot);
                                                    //replace suitableClub with kvp in club fixture
                                                    var bValue = fixedMatches[club.Id];
                                                    int bIndex = bValue.IndexOf(bValue.FirstOrDefault(kv => kv == GenerateClubPotName(suitableClub.Id, potName))!);
                                                    bValue[bIndex] = GenerateClubPotName(kvp.Key, kvpPot);

                                                    if (!ClubPotFixtureFull(kvp.Key, potName, fixedMatches, numberOfOpponentPerPot))
                                                        break;
                                                }
                                            }
                                            if (!ClubPotFixtureFull(kvp.Key, potName, fixedMatches, numberOfOpponentPerPot))
                                                break;
                                        }

                                    }
                                    else
                                    {
                                        //throw new Exception("No available club to match with");
                                    }
                                }                                
                            }
                        }
                    }
                }
            }
            foreach (var kvp in fixedMatches)
            {
                foreach (var valueVal in fixedMatches[kvp.Key])
                {
                    fixedMatchesFull[kvp.Key].Add(GetClub(valueVal, scenarioInstance.ClubsInScenarioInstance));
                    //fixedMatchesFull[ExtractClubId_Club_PotName(valueVal)].Add(GetClub(kvp.Key.ToString(), scenarioInstance.ClubsInScenarioInstance));
                }
            }    
            
            return fixedMatchesFull;
        }
        private int FoundedOpponentsInPot(string potName, Guid clubId, Dictionary<Guid, List<string>> fixedMatches)
        {
            //returns the number of opponents a club as found/booked for match in a pot
            return fixedMatches[clubId].Where(fm => fm.Contains(potName)).Count();
        }
        private string GetClubPotName(Guid clubId, IEnumerable<Pot> pots)
        {
            var choicePot = pots.FirstOrDefault( p=> p.ClubsInPot.Any( cip => cip.ClubId == clubId) );
            return choicePot == null? string.Empty: choicePot.Name;
        }
        private Pot? GetPotByName(string potName, IEnumerable<Pot>? pots)
        {
            return pots?.FirstOrDefault(p => p.Name == potName) ?? null;
        }
        private bool ClubPotFixtureFull(Guid clubId, string againstPotName, Dictionary<Guid, List<string>> fixedMatches, int target)
        {
            return fixedMatches[clubId].Where(s => s.Contains(GenerateClubPotName(null, againstPotName))).Count() >= target;
        }
        private int ClubPotFixtureCount(Guid clubId, string againstPotName, Dictionary<Guid, List<string>> fixedMatches)
        {
            return fixedMatches[clubId].Where(s => s.Contains(GenerateClubPotName(null, againstPotName))).Count();
        }
        private bool ClubHasFixtureAgainst(Guid firstClubId, Guid secondClubId, Dictionary<Guid, List<string>> fixedMatches)
        {
            return fixedMatches[firstClubId].Any(fm => fm.Contains(secondClubId.ToString()));
        }
        private string GenerateClubPotName(Guid? clubId, string potName)
        {
            return $"{clubId?.ToString() ?? string.Empty}_{potName}";
        }
        private Guid ExtractClubId_Club_PotName(string str)
        {
            return new Guid(str.Split('_')[0].ToString());
        }
        private Club GetClub(string str, IEnumerable<ClubInScenarioInstance> clubsInScenarioInstance)
        {
            var id = ExtractClubId_Club_PotName(str);
            return clubsInScenarioInstance.First( cisi => cisi.Club!.Id == id).Club!;
        }
    }
}
