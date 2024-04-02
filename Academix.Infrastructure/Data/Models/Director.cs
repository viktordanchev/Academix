using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Data.Models
{
    public class Director
    {
        public Director()
        {
            Requests = new List<Request>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string DirectorIdentityId { get; set; } = null!;

        [ForeignKey(nameof(DirectorIdentityId))]
        public ApplicationUser DirectorIdentity { get; set; } = null!;

        public ICollection<Request> Requests { get; set; }
    }
}
