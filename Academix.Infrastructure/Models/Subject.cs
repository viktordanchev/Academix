using Academix.Infrastructure.Models.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Academix.Infrastructure.Models
{
    public class Subject
    {
        public Subject()
        {
            Grades = new List<Grade>();
            SubjectStudents = new List<SubjectStudent>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public ICollection<Grade> Grades { get; set; }

        public ICollection<Absence> Absences { get; set; }

        public ICollection<SubjectStudent> SubjectStudents { get; set; }
    }
}
