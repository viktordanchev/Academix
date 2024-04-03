using System.ComponentModel.DataAnnotations;
using Academix.Infrastructure.Constants;

namespace Academix.Web.Models.Account
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        {
            Roles = new List<string>();
        }

        [Required]
        [RegularExpression(ApplicationUserConstants.NameMatch, ErrorMessage = "First Name is invalid.")]
        public string FirstName { get; set; } = null!;

        [Required]
        [RegularExpression(ApplicationUserConstants.NameMatch, ErrorMessage = "First Name is invalid.")]
        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress(ErrorMessage = "Email is invalid.")]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = null!;

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = null!;

        public IEnumerable<string> Roles { get; set; }
    }
}
