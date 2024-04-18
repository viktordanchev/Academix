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
        public string ParentId { get; set; } = null!;

        [ForeignKey(nameof(ParentId))]
        public ApplicationUser Parent { get; set; } = null!;
    }
}
