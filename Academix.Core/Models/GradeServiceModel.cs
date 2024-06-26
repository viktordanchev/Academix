﻿using Academix.Infrastructure.Data.Models.Enumerations;

namespace Academix.Core.Models
{
    public class GradeServiceModel
    {
        public int GradeNumber { get; set; }

        public DateTime DateAndTime { get; set; }

        public GradeTypes GradeType { get; set; }
    }
}
