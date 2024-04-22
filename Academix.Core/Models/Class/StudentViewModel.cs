namespace Academix.Core.Models.Class
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            Absences = new List<AbsenceServiceModel>();
            Parents = new List<ParentServiceModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Address { get; set; }

        public IEnumerable<ParentServiceModel> Parents { get; set; }

        public IEnumerable<AbsenceServiceModel> Absences { get; set; }
    }
}
