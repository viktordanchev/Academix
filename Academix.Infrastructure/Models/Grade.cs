using Academix.Infrastructure.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int GradeNumber { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }

        [Required]
        public GradeTypes GradeType { get; set; }

        [Required]
        public int SubjectId { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; } = null!;
    }
}
