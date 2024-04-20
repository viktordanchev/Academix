namespace Academix.Core.Models.Dashboard
{
    public class SubjectServiceModel
    {
        public SubjectServiceModel()
        {
            Grades = new List<GradeServiceModel>();
            Absences = new List<AbsenceServiceModel>();
        }

        public string Name { get; set; } = null!;

        public string TeacherName { get; set; } = null!;

        public IEnumerable<GradeServiceModel> Grades { get; set; }

        public IEnumerable<AbsenceServiceModel> Absences { get; set; }
    }
}
