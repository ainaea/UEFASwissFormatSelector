using System.ComponentModel.DataAnnotations;

namespace UEFASwissFormatSelector.Models
{
    public class Scenario : Identifiable
    {
        [Display(Name = "Number of pots")]
        public int NumberOfPot { get; set; }
        [Display(Name = "Number of Teams in a pot")]
        public int NumberOfTeamsPerPot { get; set; }
        [Display(Name = "Number of Opponents in a pot")]
        public int NumberOfGamesPerPot { get; set; }
        [Display(Name = "Number of Opponents in a pot")]
        public bool HomeAndAwayPerOpponent { get; set; }
    }
}
