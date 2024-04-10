using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Academix.Common.Constants;

namespace Academix.Infrastructure.Data.Models
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
