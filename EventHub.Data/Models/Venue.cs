
using System.ComponentModel.DataAnnotations;

using static EventHub.Common.Constants.EntityValidationConstants.Venue;

namespace EventHub.Data.Models
{
    public class Venue
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(CityMaxLength)]
        public string City { get; set; } = string.Empty;
    }
}
