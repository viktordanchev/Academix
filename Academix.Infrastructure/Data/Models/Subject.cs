using Academix.Infrastructure.Data.Models.Mapping;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Data.Models
{
    public class Subject
    {
        public Subject()
        {
            Grades = new List<Grade>();
            Absences = new List<Absence>();
            SubjectStudents = new List<SubjectStudent>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int TeacherId { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; } = null!;

        public IEnumerable<Grade> Grades { get; set; }

        public IEnumerable<Absence> Absences { get; set; }

        public IEnumerable<SubjectStudent> SubjectStudents { get; set; }
    }
}
