using Academix.Core.Contracts;
using Academix.Core.Services;
using Academix.Infrastructure.Data;

namespace Academix.Tests.Tests
{
    [TestFixture]
    public class DashboardServiceTests
    {
        private AcademixDbContext context;
        private IDashboardService service;

        private readonly string studentId = "1ae342a8-9fab-4c0a-bd5a-70b351717ecc";
        private readonly string student2Id = "a171483f-6e48-446a-a5d7-36110d0c1443";

        [SetUp]
        public void SetUp()
        {
            context = MockDatabase.Instance();
            service = new DashboardService(context);
        }

        [TearDown]
        public void TearDown()
        {
            context.Database.EnsureDeletedAsync();
        }

        [Test]
        public void GetStudentAsync_ShouldReturnCurrentStudent()
        {
            var student = service.GetStudentAsync(studentId).Result;
            var student2 = service.GetStudentAsync(student2Id).Result;

            Assert.AreEqual("Vasil Levski", student.School);
            Assert.AreEqual("Vasil Levski", student2.School);
            Assert.AreEqual(1, student.Id);
            Assert.AreEqual(2, student2.Id);
        }

        [Test]
        public void GetAllSubjectsAsync_ShouldReturnSubjectsToCurrentStudent()
        {
            var student = service.GetStudentAsync(studentId).Result.Id;
            var student2 = service.GetStudentAsync(student2Id).Result.Id;

            var subjects = service.GetAllSubjectsAsync(student).Result;
            var subjects2 = service.GetAllSubjectsAsync(student2).Result;

            Assert.AreEqual(3, subjects.Count());
            Assert.AreEqual(1, subjects2.Count());
        }
    }
}
