﻿using Academix.Infrastructure.Data.Models.Enumerations;

namespace Academix.Core.Models.StudentHome
{
    public class AbsenceServiceModel
    {
        public bool ExcusedAbsence { get; set; }

        public DateTime DateAndTime { get; set; }

        public AbsenceTypes AbsenceType { get; set; }
    }
}