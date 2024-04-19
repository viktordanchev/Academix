using System.ComponentModel.DataAnnotations;

namespace Academix.Web.Models.Account
{
    public class AddRoleViewModel
    {
        public AddRoleViewModel()
        {
            Roles = new List<string>();
            Schools = new List<InfoViewModel>();
        }

        [Required(ErrorMessage = "The Role field is required.")]
        public string Role { get; set; } = null!;

        [Required(ErrorMessage = "The School field is required.")]
        public int SchoolId { get; set; }

        [Required(ErrorMessage = "The Class field is required.")]
        public int ClassId { get; set; }

        [Required(ErrorMessage = "The Student field is required.")]
        public int StudentId { get; set; }

        public IEnumerable<string> Roles { get; set; }

        public IEnumerable<InfoViewModel> Schools { get; set; }
    }
}
