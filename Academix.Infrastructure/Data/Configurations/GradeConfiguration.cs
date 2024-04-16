using Academix.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academix.Infrastructure.Data.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder
                .HasOne(g => g.Student)
                .WithMany(s => s.Grades)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(DataSeed.SeedGrades());
        }
    }
}
