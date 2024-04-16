using Academix.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academix.Infrastructure.Data.Configurations
{
    public class AbsenceConfiguration : IEntityTypeConfiguration<Absence>
    {
        public void Configure(EntityTypeBuilder<Absence> builder)
        {
            builder
                .HasOne(a => a.Student)
                .WithMany(s => s.Absences)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(DataSeed.SeedAbsences());
        }
    }
}
