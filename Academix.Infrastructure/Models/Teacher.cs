using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TeacherIdentityId { get; set; } = null!;

        [ForeignKey(nameof(TeacherIdentityId))]
        public ApplicationUser TeacherIdentity { get; set; } = null!;

        public int SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public School School { get; set; } = null!;

        [Required]
        public int SubjectId { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; } = null!;
    }
}
