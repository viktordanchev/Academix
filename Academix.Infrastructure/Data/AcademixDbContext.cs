using Academix.Infrastructure.Data.Configurations;
using Academix.Infrastructure.Data.Models;
using Academix.Infrastructure.Data.Models.Mapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Academix.Infrastructure.Data
{
    public class AcademixDbContext : IdentityDbContext<ApplicationUser>
    {
        public AcademixDbContext(DbContextOptions<AcademixDbContext> options)
            : base(options)
        {
        }

        public DbSet<Absence> Absences { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SubjectStudent> SubjectsStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AbsenceConfiguration());
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new CityConfiguration());
            builder.ApplyConfiguration(new ClassConfiguration());
            builder.ApplyConfiguration(new DirectorConfiguration());
            builder.ApplyConfiguration(new GradeConfiguration());
            builder.ApplyConfiguration(new IdentityRoleConfiguration());
            builder.ApplyConfiguration(new ParentConfiguration());
            builder.ApplyConfiguration(new RequestConfiguration());
            builder.ApplyConfiguration(new SchoolConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new SubjectConfiguration());
            builder.ApplyConfiguration(new SubjectStudentConfiguration());
            builder.ApplyConfiguration(new TeacherConfiguration());
            builder.ApplyConfiguration(new IdentityUserRoleConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
