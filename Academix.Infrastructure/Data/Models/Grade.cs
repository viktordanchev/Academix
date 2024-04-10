using Academix.Common.Constants;
using Academix.Infrastructure.Data.Models.Enumerations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Data.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(GradeConstants.GradeNumberMin, GradeConstants.GradeNumberMax)]
        public int GradeNumber { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }

        [Required]
        [Range(GradeConstants.GradeTypeMin, GradeConstants.GradeTypeMax)]
        public GradeTypes GradeType { get; set; }

        [Required]
        public int SubjectId { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; } = null!;
    }
}
