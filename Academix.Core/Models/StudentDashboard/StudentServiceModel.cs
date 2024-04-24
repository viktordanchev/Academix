namespace Academix.Core.Models.Dashboard
{
    public class StudentServiceModel
    {
        public int Id { get; set; }

        public string School { get; set; } = null!;

        public string SchoolCity { get; set; } = null!;

        public string Class { get; set; } = null!;

        public string? ClassTeacher { get; set; }
    }
}
