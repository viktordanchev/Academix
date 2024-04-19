namespace Academix.Core.Models.ParentHome
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            Subjects = new List<SubjectServiceModel>();
        }

        public int? NumberInClass { get; set; }

        public string Name { get; set; } = null!;

        public string Class { get; set; } = null!;

        public string? ClassTeacher { get; set; }

        public string School { get; set; } = null!;

        public string? SchoolDirector { get; set; }

        public IEnumerable<SubjectServiceModel> Subjects { get; set; }
    }
}
