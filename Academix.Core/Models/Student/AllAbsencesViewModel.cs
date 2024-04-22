namespace Academix.Core.Models.Student
{
    public class AllAbsencesViewModel
    {
        public int AbsenceId { get; set; }

        public int StudentId { get; set; }

        public string Excused { get; set; } = null!;

        public DateTime DateAndTime { get; set; }
    }
}
