using Academix.Infrastructure.Data.Models.Enumerations;

namespace Academix.Core.Models.Student
{
    public class AllGradesViewModel
    {
        public int Id { get; set; }

        public int GradeNumber { get; set; }

        public DateTime DateAndTime { get; set; }

        public GradeTypes GradeType { get; set; }
    }
}
