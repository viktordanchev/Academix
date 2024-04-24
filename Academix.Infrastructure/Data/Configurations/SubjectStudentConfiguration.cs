using Academix.Infrastructure.Data.Models.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academix.Infrastructure.Data.Configurations
{
    public class SubjectStudentConfiguration : IEntityTypeConfiguration<SubjectStudent>
    {
        public void Configure(EntityTypeBuilder<SubjectStudent> builder)
        {
            builder
                .HasKey(ss => new { ss.SubjectId, ss.StudentId });

            builder
                .HasOne(ss => ss.Subject)
                .WithMany(s => s.SubjectStudents)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(ss => ss.Student)
                .WithMany(s => s.SubjectsStudent)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(DataSeed.SeedSubjectsStudents());
        }
    }
}
