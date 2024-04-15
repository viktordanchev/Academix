using Academix.Common.Constants;
using System.ComponentModel.DataAnnotations;

namespace Academix.Web.Models.Account
{
    public class ManageViewModel
    {
        [Required(ErrorMessage = "The First name field is required.")]
        [RegularExpression(ApplicationUserConstants.NameMatch)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "The Last name field is required.")]
        [RegularExpression(ApplicationUserConstants.NameMatch)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Email is invalid.")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "Phone number is invalid.")]
        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }
    }
}
