using Academix.Infrastructure.Models.Mapping;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Models
{
    public class Student
    {
        public Student()
        {
            StudentsSubjects = new List<SubjectsStudents>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string StudentIdentityId { get; set; } = null!;

        [ForeignKey(nameof(StudentIdentityId))]
        public ApplicationUser StudentIdentity { get; set; } = null!;

        [Required]
        public int SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public School School { get; set; } = null!;

        [Required]
        public int ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public Parent Parent { get; set; } = null!;

        public ICollection<SubjectsStudents> StudentsSubjects { get; set; }
    }
}
