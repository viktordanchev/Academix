using System.ComponentModel.DataAnnotations;

namespace Academix.Web.Models.Account
{
    public class IdentityRoleViewModel
    {
        public string Id { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;
    }
}
