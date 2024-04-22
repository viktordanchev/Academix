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
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SubjectStudent> SubjectsStudents { get; set; }
        public DbSet<StudentParent> StudentsParents { get; set; }
        public DbSet<RequestReceiver> RequestsReceivers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new IdentityRoleConfiguration());
            builder.ApplyConfiguration(new IdentityUserRoleConfiguration());
            builder.ApplyConfiguration(new IdentityUserClaimConfiguration());
            builder.ApplyConfiguration(new AbsenceConfiguration());
            builder.ApplyConfiguration(new CityConfiguration());
            builder.ApplyConfiguration(new ClassConfiguration());
            builder.ApplyConfiguration(new GradeConfiguration());
            builder.ApplyConfiguration(new SchoolConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new SubjectConfiguration());
            builder.ApplyConfiguration(new TeacherConfiguration());
            builder.ApplyConfiguration(new StudentParentConfiguration());
            builder.ApplyConfiguration(new SubjectStudentConfiguration());
            builder.ApplyConfiguration(new RequestReceiverConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
