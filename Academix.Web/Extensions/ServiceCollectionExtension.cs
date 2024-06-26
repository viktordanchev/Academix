﻿using Academix.Core.Contracts;
using Academix.Core.Services;
using Academix.Infrastructure.Data;
using Academix.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Academix.Web.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IDirectorStudentService, DirectorStudentService>();
            services.AddScoped<IDirectorSubjectService, DirectorSubjectService>();
            services.AddScoped<ITeacherClassService, TeacherClassService>();
            services.AddScoped<ITeacherStudentService, TeacherStudentService>();
            services.AddScoped<IParentStudentService, ParentStudentService>();
            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IStudentDashboardService, StudentDashboardService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AcademixDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services)
        {
            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredLength = 6;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<AcademixDbContext>();
            services.AddControllersWithViews();

            return services;
        }
    }
}
