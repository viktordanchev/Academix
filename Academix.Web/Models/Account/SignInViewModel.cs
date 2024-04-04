using System.ComponentModel.DataAnnotations;

namespace Academix.Web.Models.Account
{
    public class SignInViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Email is invalid.")]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
