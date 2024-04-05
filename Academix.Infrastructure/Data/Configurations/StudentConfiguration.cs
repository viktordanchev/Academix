using Academix.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academix.Infrastructure.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .HasOne(s => s.Class)
                .WithMany(s => s.Students)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(DataSeed.SeedStudents());
        }
    }
}
