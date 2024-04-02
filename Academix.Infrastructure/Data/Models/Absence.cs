using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Academix.Infrastructure.Constants;
using Academix.Infrastructure.Data.Models.Enumerations;

namespace Academix.Infrastructure.Data.Models
{
    public class Absence
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }

        [Required]
        [Range(AbsenceConstants.AbsenceTypeMin, AbsenceConstants.AbsenceTypeMax)]
        public AbsenceTypes AbsenceType { get; set; }

        [Required]
        public int SubjectId { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; } = null!;
    }
}
