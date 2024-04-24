using Academix.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using static Academix.Infrastructure.Data.Configurations.DataSeed;

namespace Academix.Tests
{
    public static class MockDatabase
    {
        public static AcademixDbContext Instance()
        {
            var options = new DbContextOptionsBuilder<AcademixDbContext>()
                .UseInMemoryDatabase("Academix")
                .Options;

            var context = new AcademixDbContext(options);
            context.AddRange(SeedAbsences());
            context.AddRange(SeedApplicationUsers());
            context.AddRange(SeedCities());
            context.AddRange(SeedClasses());
            context.AddRange(SeedGrades());
            context.AddRange(SeedSchools());
            context.AddRange(SeedStudents());
            context.AddRange(SeedSubjects());
            context.AddRange(SeedSubjectsStudents());
            context.AddRange(SeedStudentsParents());
            context.AddRange(SeedTeachers());
            context.SaveChanges();

            return context;
        }
    }
}
