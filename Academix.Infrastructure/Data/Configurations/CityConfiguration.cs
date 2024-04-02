using Academix.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academix.Infrastructure.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder
                .HasData(
                    new City
                    {
                        Id = 1,
                        Name = "Sofia"
                    }, 
                    new City
                    {
                        Id = 2,
                        Name = "Varna"
                    });
        }
    }
}
