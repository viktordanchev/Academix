namespace Academix.Core.Models.Student
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? ClassTeacher { get; set; }

        public int SchoolId { get; set; }

        public int? ClassId { get; set; }

        public int? StudentId { get; set; }
    }
}
