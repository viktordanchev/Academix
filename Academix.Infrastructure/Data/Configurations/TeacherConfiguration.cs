using Academix.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academix.Infrastructure.Data.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder
                .HasOne(t => t.School)
                .WithMany(s => s.Teachers)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(DataSeed.SeedTeachers());
        }
    }
}
