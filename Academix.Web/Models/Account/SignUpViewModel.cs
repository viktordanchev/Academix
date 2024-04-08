using System.ComponentModel.DataAnnotations;
using Academix.Infrastructure.Constants;

namespace Academix.Web.Models.Account
{
    public class SignUpViewModel
    {
        public SignUpViewModel()
        {
            Roles = new List<IdentityRoleViewModel>();
            Schools = new List<InfoViewModel>();
        }

        [Required(ErrorMessage = "The First name field is required.")]
        [RegularExpression(ApplicationUserConstants.NameMatch, ErrorMessage = "First name is invalid.")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "The Last name field is required.")]
        [RegularExpression(ApplicationUserConstants.NameMatch, ErrorMessage = "First name is invalid.")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Email is invalid.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "The Password field is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = null!;

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = null!;

        [Required(ErrorMessage = "The Role field is required.")]
        public string IdentityRoleId { get; set; } = null!;

        [Required(ErrorMessage = "The School field is required.")]
        public int SchoolId { get; set; }

        [Required(ErrorMessage = "The Class field is required.")]
        public int ClassId { get; set; }

        public IEnumerable<IdentityRoleViewModel> Roles { get; set; }

        public IEnumerable<InfoViewModel> Schools { get; set; }
    }
}
