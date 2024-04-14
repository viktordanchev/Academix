using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Academix.Core.Models.Request
{
    public class RequestServiceModel
    {
        public int Id { get; set; }

        public string Role { get; set; } = null!;

        

        public int SchoolId { get; set; }

        public int? ClassId { get; set; }

        public int? StudentId { get; set; }

        public string? Message { get; set; }
    }
}
