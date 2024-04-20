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
            StudentParents = new List<StudentParent>();
            Grades = new List<Grade>();
            Absences = new List<Absence>();
        }

        [Key]
        public int Id { get; set; }

        public string? Address { get; set; }

        [Required]
        public string StudentIdentityId { get; set; } = null!;

        [ForeignKey(nameof(StudentIdentityId))]
        public ApplicationUser StudentIdentity { get; set; } = null!;

        [Required]
        public int ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        public Class Class { get; set; } = null!;

        public IEnumerable<SubjectStudent> SubjectsStudent { get; set; }

        public IEnumerable<StudentParent> StudentParents { get; set; }

        public IEnumerable<Grade> Grades { get; set; }

        public IEnumerable<Absence> Absences { get; set; }
    }
}
