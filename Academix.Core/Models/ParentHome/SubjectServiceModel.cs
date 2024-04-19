namespace Academix.Core.Models.ParentHome
{
    public class SubjectServiceModel
    {
        public SubjectServiceModel()
        {
            Grades = new List<int>();
        }

        public string Name { get; set; } = null!;

        public int Absences { get; set; }

        public IEnumerable<int> Grades { get; set; }

    }
}
