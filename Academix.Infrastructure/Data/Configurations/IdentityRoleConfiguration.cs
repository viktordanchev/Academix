using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academix.Infrastructure.Data.Configurations
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder
                .HasData(new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Director", NormalizedName = "DIRECTOR" });
            builder
                .HasData(new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Teacher", NormalizedName = "TEACHER" });
            builder
                .HasData(new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Student", NormalizedName = "STUDENT" });
            builder
                .HasData(new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Parent", NormalizedName = "PARENT" });
            builder
                .HasData(new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Administrator", NormalizedName = "ADMINISTRATOR" });
        }
    }
}
