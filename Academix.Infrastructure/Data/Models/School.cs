using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Data.Models
{
    public class School
    {
        public School()
        {
            Teachers = new List<Teacher>();
            Classes = new List<Class>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public City City { get; set; } = null!;

        public int? DirectorId { get; set; }

        [ForeignKey(nameof(DirectorId))]
        public Director? Director { get; set; }

        public IEnumerable<Teacher> Teachers { get; set; }

        public IEnumerable<Class> Classes { get; set; }
    }
}
