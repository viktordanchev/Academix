using System.ComponentModel.DataAnnotations;

namespace Academix.Web.Models.Account
{
    public class InfoViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
