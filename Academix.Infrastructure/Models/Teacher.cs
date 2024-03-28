using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public IdentityUser User { get; set; } = null!;

        public int SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public School School { get; set; } = null!;

        public string? Address { get; set; }
    }
}
