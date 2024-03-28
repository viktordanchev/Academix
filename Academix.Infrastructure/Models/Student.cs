using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Models
{
    public class Student
    {
        public Student()
        {
            Subjects = new List<Subject>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public IdentityUser User { get; set; } = null!;

        [Required]
        public int SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public School School { get; set; } = null!;

        [Required]
        public int ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public Parent Parent { get; set; } = null!;

        public ICollection<Subject> Subjects { get; set; }
    }
}
