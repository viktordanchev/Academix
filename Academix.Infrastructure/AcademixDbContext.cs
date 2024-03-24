using Academix.Infrastructure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Academix.Infrastructure
{
    public class AcademixDbContext : IdentityDbContext<ApplicationUser>
    {
        public AcademixDbContext(DbContextOptions<AcademixDbContext> options)
            : base(options)
        {
        }
    }
}
