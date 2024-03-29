using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Academix.Infrastructure.Models.Enums;

namespace Academix.Infrastructure.Models
{
    public class Absence
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }

        [Required]
        public AbsenceTypes AbsenceType { get; set; }

        [Required]
        public int SubjectId { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; } = null!;
    }
}
