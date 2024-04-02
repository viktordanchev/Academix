using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Data.Models
{
    public class Parent
    {
        public Parent()
        {
            Students = new List<Student>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string ParentIdentityId { get; set; } = null!;

        [ForeignKey(nameof(ParentIdentityId))]
        public ApplicationUser ParentIdentity { get; set; } = null!;

        public ICollection<Student> Students { get; set; }
    }
}
