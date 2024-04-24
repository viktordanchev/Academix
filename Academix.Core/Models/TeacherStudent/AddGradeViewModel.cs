using Academix.Common.Constants;
using Academix.Infrastructure.Data.Models.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace Academix.Core.Models.Student
{
    public class AddGradeViewModel
    {
        public AddGradeViewModel()
        {
            GradeTypes = new List<GradeTypeServiceModel>();
        }

        [Range(GradeConstants.GradeNumberMin, GradeConstants.GradeNumberMax, ErrorMessage = "The grade must be between 2 - 6")]
        public int GradeNumber { get; set; }

        public GradeTypes GradeType { get; set; }

        public int SubjectId { get; set; }

        public IEnumerable<GradeTypeServiceModel> GradeTypes { get; set; }
    }
}
