namespace Academix.Core.Models.Request
{
    public class RequestServiceModel
    {
        public int Id { get; set; }

        public string Role { get; set; } = null!;

        public int? DirectorId { get; set; }

        public int? AdminId { get; set; }

        public string RequesterId { get; set; } = null!;

        public int SchoolId { get; set; }

        public int? ClassId { get; set; }

        public int? StudentId { get; set; }

        public string? Message { get; set; }
    }
}
