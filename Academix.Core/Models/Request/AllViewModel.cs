namespace Academix.Core.Models.Request
{
    public class AllViewModel
    {
        public int Id { get; set; }

        public string Role { get; set; } = null!;

        public string RequesterName { get; set; } = null!;

        public string School { get; set; } = null!;

        public string? Class { get; set; }

        public string? Student { get; set; }

        public string? Message { get; set; }
    }
}
