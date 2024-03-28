using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Academix.Infrastructure.Models
{
    public class Parent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public IdentityUser User { get; set; } = null!;


        public int MyProperty { get; set; }
    }
}
