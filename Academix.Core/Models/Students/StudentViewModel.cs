namespace Academix.Core.Models.Students
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            Subjects = new List<SubjectServiceModel>();
        }

        public string Name { get; set; } = null!;

        public string Class { get; set; } = null!;

        public string? ClassTeacher { get; set; }

        public string School { get; set; } = null!;

        public string? SchoolDirector { get; set; }

        public IEnumerable<SubjectServiceModel> Subjects { get; set; }
    }
}
