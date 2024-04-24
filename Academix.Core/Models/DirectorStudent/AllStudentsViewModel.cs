namespace Academix.Core.Models.DirectorStudent
{
    public class AllStudentsViewModel
    {
        public AllStudentsViewModel()
        {
            TotalGrade = new List<double>();
        }

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public List<double> TotalGrade { get; set; }
    }
}
