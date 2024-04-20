namespace Academix.Core.Models.Dashboard
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            Subjects = new List<SubjectServiceModel>();
        }

        public StudentServiceModel Student { get; set; } = null!;

        public IEnumerable<SubjectServiceModel> Subjects { get; set; }
    }
}
