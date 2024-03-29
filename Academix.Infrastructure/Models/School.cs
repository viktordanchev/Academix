using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Models
{
    public class School
    {
        public School()
        {
            Teachers = new List<Teacher>();
            Students = new List<Student>();
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

        [Required]
        public int DirectorId { get; set; }

        [ForeignKey(nameof(DirectorId))]
        public Director Director { get; set; } = null!;

        public ICollection<Teacher> Teachers { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Class> Classes { get; set; }
    }
}
