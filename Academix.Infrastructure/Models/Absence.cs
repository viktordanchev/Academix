using System.ComponentModel.DataAnnotations;
using Academix.Infrastructure.Models.Enums;

namespace Academix.Infrastructure.Models
{
    public class Absence
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }

        [Required]
        public AbsenceTypes AbsenceType { get; set; }
    }
}
