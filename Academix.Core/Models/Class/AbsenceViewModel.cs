namespace Academix.Core.Models.Class
{
    public class AbsenceViewModel
    {
        public int AbsenceId { get; set; }

        public int StudentId { get; set; }

        public string Excused { get; set; } = null!;

        public DateTime DateAndTime { get; set; }
    }
}
