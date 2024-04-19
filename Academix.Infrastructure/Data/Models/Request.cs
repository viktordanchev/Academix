using Academix.Infrastructure.Data.Models.Mapping;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Data.Models
{
    public class Request
    {
        public Request()
        {
            RequestReceivers = new List<RequestReceiver>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Role { get; set; } = null!;

        [Required]
        public string RequesterId { get; set; } = null!;

        [ForeignKey(nameof(RequesterId))]
        public ApplicationUser Requester { get; set; } = null!;

        [Required]
        public int SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public School School { get; set; } = null!;

        public int? ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        public Class? Class { get; set; }

        public int? StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student? Student { get; set; }

        public IEnumerable<RequestReceiver> RequestReceivers { get; set; }
    }
}
