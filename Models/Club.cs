using System.ComponentModel.DataAnnotations;

namespace UEFASwissFormatSelector.Models
{
    public class Club: Identifiable
    {
        public string? Logo { get; set; }
        public Country? Country { get; set; }
        [Required]
        public Guid CountryId { get; set; }
    }
}
