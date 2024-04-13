using Academix.Infrastructure.Data.Models.Mapping;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Data.Models
{
    public class Parent
    {
        public Parent()
        {
            StudentsParent = new List<StudentParent>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string ParentIdentityId { get; set; } = null!;

        [ForeignKey(nameof(ParentIdentityId))]
        public ApplicationUser ParentIdentity { get; set; } = null!;

        public IEnumerable<StudentParent> StudentsParent { get; set; }
    }
}
