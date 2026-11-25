
using System.ComponentModel.DataAnnotations;

using static EventHub.Common.Constants.EntityValidationConstants.Category;

namespace EventHub.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;
    }
}
