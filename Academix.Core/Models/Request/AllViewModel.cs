using System.ComponentModel.DataAnnotations;

namespace Academix.Core.Models.Request
{
    public class AllViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Role { get; set; } = null!;

        [Required]
        public string RequesterName { get; set; } = null!;

        public string? Message { get; set; }
    }
}
