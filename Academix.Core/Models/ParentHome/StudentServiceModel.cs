namespace Academix.Core.Models.ParentHome
{
    public class StudentServiceModel
    {
        public StudentServiceModel()
        {
            Grades = new List<GradeServiceModel>();
            Absences = new List<AbsenceServiceModel>();
        }

        public int? NumberInClass { get; set; }

        public string Name { get; set; } = null!;

        public string Class { get; set; } = null!;

        public string? ClassTeacher { get; set; }

        public string School { get; set; } = null!;

        public string SchoolDirector { get; set; } = null!;

        public IEnumerable<GradeServiceModel> Grades { get; set; }

        public IEnumerable<AbsenceServiceModel> Absences { get; set; }
    }
}
