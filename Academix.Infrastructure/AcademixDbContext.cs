using Academix.Infrastructure.Models;
using Academix.Infrastructure.Models.Mapping;
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

        public DbSet<Absence> Absences { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SubjectsStudents> SubjectsStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SubjectsStudents>()
                .HasKey(ss => new { ss.StudentId, ss.SubjectId });

            builder.Entity<Student>()
                .HasOne(s => s.Parent)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Student>()
                .HasOne(s => s.School)
                .WithMany(s => s.Students)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Teacher>()
                .HasOne(t => t.School)
                .WithMany(s => s.Teachers)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
