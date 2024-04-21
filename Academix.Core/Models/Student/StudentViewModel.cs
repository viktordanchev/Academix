namespace Academix.Core.Models.Student
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            Grades = new List<GradeServiceModel>();
            Absences = new List<AbsenceServiceModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Class { get; set; } = null!;

        public string? ClassTeacher { get; set; }

        public IEnumerable<GradeServiceModel> Grades { get; set; }

        public IEnumerable<AbsenceServiceModel> Absences { get; set; }
    }
}
