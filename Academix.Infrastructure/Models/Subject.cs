using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Models
{
    public class Subject
    {
        public Subject()
        {
            Grades = new List<Grade>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int TeacherId { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; } = null!;

        [Required]
        public int StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; } = null!;

        public ICollection<Grade> Grades { get; set; }

        public ICollection<Grade> Grades { get; set; }
    }
}
