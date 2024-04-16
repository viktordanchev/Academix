namespace Academix.Core.Models.StudentHome
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

        public double AverageGrade {  get; set; }

        public IEnumerable<GradeServiceModel> Grades { get; set; }

        public IEnumerable<AbsenceServiceModel> Absences { get; set; }
    }
}
