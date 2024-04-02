using Academix.Infrastructure.Data.Models.Mapping;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Data.Models
{
    public class Student
    {
        public Student()
        {
            SubjectsStudent = new List<SubjectStudent>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public int NumberInClass { get; set; }

        [Required]
        public string StudentIdentityId { get; set; } = null!;

        [ForeignKey(nameof(StudentIdentityId))]
        public ApplicationUser StudentIdentity { get; set; } = null!;

        [Required]
        public int ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        public Class Class { get; set; } = null!;

        [Required]
        public int SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public School School { get; set; } = null!;

        [Required]
        public int ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public Parent Parent { get; set; } = null!;

        public ICollection<SubjectStudent> SubjectsStudent { get; set; }
    }
}
