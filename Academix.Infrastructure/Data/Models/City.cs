using System.ComponentModel.DataAnnotations;

namespace Academix.Infrastructure.Data.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
