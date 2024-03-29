using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DirectorIdentityId { get; set; } = null!;

        [ForeignKey(nameof(DirectorIdentityId))]
        public ApplicationUser DirectorIdentity { get; set; } = null!;
    }
}
