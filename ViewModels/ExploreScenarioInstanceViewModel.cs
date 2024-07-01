using System.Reflection;
using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.ViewModels
{
    public class ExploreScenarioInstanceViewModel: ScenarioInstance
    {
        public bool NoClubInScenarioInstance { get=> this.ClubsInScenarioInstance == null || this.ClubsInScenarioInstance.Count() == 0 || this.ClubsInScenarioInstance.Any(c => c == null); }
        public bool ClubsCanBePotted { get => !NoClubInScenarioInstance; }
        public bool ClubsNotPotted { get=> Pots.Any(p => p == null) || Pots.Count() == 0; }
        public bool ClubOpponentsCanBeGenerated { get => !ClubsNotPotted && ClubsCanBePotted; }
        public bool ClubOpponentsNotGenerated { get=> !ClubsNotPotted && Pots.Any(c => c.ClubsInPot != null) && Opponents == null; }
        public bool MatchupsCanBeDecided { get => !ClubOpponentsNotGenerated && ClubOpponentsCanBeGenerated; }
        public bool MatchupsNotDecided { get=> Opponents != null && MatchUps == null; }
        public bool CanDisplayMatchUp { get=> MatchUps != null; }
        //Teams
        //Pots
        //Matches
    }
}
