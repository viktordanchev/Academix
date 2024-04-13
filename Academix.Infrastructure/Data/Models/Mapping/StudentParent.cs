using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Academix.Infrastructure.Data.Models.Mapping
{
    public class StudentParent
    {
        [Required]
        public int StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; } = null!;

        [Required]
        public int ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public Parent Parent { get; set; } = null!;
    }
}
