using Academix.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContext(builder.Configuration);
builder.Services.AddApplicationIdentity();
builder.Services.AddApplicationServices();

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/SignIn";
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error/500");
    app.UseStatusCodePagesWithRedirects("/Home/Error?statusCode={0}");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "Areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "Student All Grades",
        pattern: "Teacher/Student/AllGrades/{studentId}",
        defaults: new { Controller = "Student", Action = "AllGrades" });

    endpoints.MapControllerRoute(
        name: "Student All Absences",
        pattern: "Teacher/Student/AllAbsences/{studentId}",
        defaults: new { Controller = "Student", Action = "AllAbsences" });

    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Authentication}/{id?}");

    endpoints.MapRazorPages();
});

app.Run();
