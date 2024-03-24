using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Academix.Infrastructure.Constants;

namespace Academix.Infrastructure.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [RegularExpression(ApplicationUserConstants.NameMatch)]
        public string FirstName { get; set; } = null!;

        [Required]
        [RegularExpression(ApplicationUserConstants.NameMatch)]
        public string LastName { get; set; } = null!;
    }
}
