using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Data.Models
{
    public class Admin
    {
        public Admin()
        {
            Requests = new List<Request>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string AdminIdentityId { get; set; } = null!;

        [ForeignKey(nameof(AdminIdentityId))]
        public ApplicationUser AdminIdentity { get; set; } = null!;

        public IEnumerable<Request> Requests { get; set; }
    }
}
