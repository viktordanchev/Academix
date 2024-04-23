using System.ComponentModel.DataAnnotations;

namespace Academix.Core.Models.Subject
{
    public class AddSubjectViewModel
    {
        public AddSubjectViewModel()
        {
            Teachers = new List<AllTeachersViewModel>();
        }

        [Required(ErrorMessage = "Subject name is required")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Teacher is required")]
        public int TeacherId { get; set; }

        public IEnumerable<AllTeachersViewModel> Teachers { get; set; }
    }
}
