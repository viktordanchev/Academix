using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Data.Models
{
    public class Request
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DirectorId { get; set; }

        [ForeignKey(nameof(DirectorId))]
        public Director Director { get; set; } = null!;

        public string? Message { get; set; }

        [Required]
        public string Requester { get; set; } 
    }
}
