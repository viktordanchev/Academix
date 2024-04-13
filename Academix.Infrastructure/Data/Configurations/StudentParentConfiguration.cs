using Academix.Infrastructure.Data.Models.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academix.Infrastructure.Data.Configurations
{
    public class StudentParentConfiguration : IEntityTypeConfiguration<StudentParent>
    {
        public void Configure(EntityTypeBuilder<StudentParent> builder)
        {
            builder
                .HasKey(sp => new { sp.StudentId, sp.ParentId });

            builder
                .HasOne(sp => sp.Student)
                .WithMany(s => s.StudentParents)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(sp => sp.Parent)
                .WithMany(p => p.StudentsParent)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(DataSeed.SeedStudentParent());
        }
    }
}
