namespace Academix.Core.Models.StudentHome
{
    public class DashboardViewModel
    {
        public DashboardViewModel()
        {
            Subjects = new List<SubjectServiceModel>();
        }

        public StudentServiceModel Student { get; set; } = null!;

        public IEnumerable<SubjectServiceModel> Subjects { get; set; }
    }
}
