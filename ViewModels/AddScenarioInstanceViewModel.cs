using System.ComponentModel.DataAnnotations;
using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.ViewModels
{
    public class AddScenarioInstanceViewModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public virtual Scenario Scenario { get; set; }
    }
}
