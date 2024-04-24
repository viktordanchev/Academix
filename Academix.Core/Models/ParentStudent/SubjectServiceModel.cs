namespace Academix.Core.Models.Students
{
    public class SubjectServiceModel
    {
        public SubjectServiceModel()
        {
            Grades = new List<GradeServiceModel>();
        }

        public string Name { get; set; } = null!;

        public int Absences { get; set; }

        public IEnumerable<GradeServiceModel> Grades { get; set; }

    }
}
