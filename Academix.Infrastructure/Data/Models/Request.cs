using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Data.Models
{
    public class Request
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Role { get; set; } = null!;
         
        [Required]
        public int DirectorId { get; set; }

        [ForeignKey(nameof(DirectorId))]
        public Director Director { get; set; } = null!;

        [Required]
        public string RequesterId { get; set; } = null!;

        [ForeignKey(nameof(RequesterId))]
        public ApplicationUser Requester { get; set; } = null!;

        [Required]
        public int SchoolId { get; set; }

        public int? ClassId { get; set; }

        public int? StudentId { get; set; }

        public string? Message { get; set; }
    }
}
