using Academix.Core.Contracts;
using Academix.Core.Services;
using Academix.Infrastructure.Data;

namespace Academix.Tests.Tests
{
    [TestFixture]
    public class ClassServiceTests
    {
        private AcademixDbContext context;
        private IClassService service;

        [SetUp]
        public void SetUp()
        {
            context = MockDatabase.Instance();
            service = new ClassService(context);
        }

        [TearDown]
        public void TearDown()
        {
            context.Database.EnsureDeletedAsync();
        }

        [Test]
        public void GetClassIdAsync_ShouldReturnCurrentClass()
        {
            var teacher = "5093413e-4acb-471a-9ce7-53df30689fc1";
            var teacher2 = "6c1ff15b-1853-4d20-98ff-9695affb432c";

            var classId = service.GetClassIdAsync(teacher).Result;
            var classId2 = service.GetClassIdAsync(teacher2).Result;

            Assert.AreEqual(1, classId);
            Assert.AreEqual(2, classId2);
        }

        [Test]
        public void GetStudentsAsync_ShouldReturnStudentsFromCurrentClass()
        {
            var students = service.GetStudentsAsync(1).Result;
            var students2 = service.GetStudentsAsync(2).Result;

            Assert.AreEqual(2, students.Count());
            Assert.AreEqual(1, students2.Count());
            Assert.AreEqual("Mitko Marinov", students.First().Name);
            Assert.AreEqual("Marta Kirilova", students2.First().Name);
        }

        [Test]
        public void GetAbsencesAsync_ShouldReturnCountOfAbsencesForStudent()
        {
            var absences = service.GetAbsencesAsync(1).Result;
            var absences2 = service.GetAbsencesAsync(2).Result;

            Assert.AreEqual(3, absences.Count());
            Assert.AreEqual(0, absences2.Count());
        }


        [Test]
        public void UpdatedAbsenceAsync_ShoulMakeAbsenceExcused()
        {
            service.UpdatedAbsenceAsync(1);

            var absence = service.GetAbsencesAsync(1).Result.First();

            Assert.AreEqual("Yes", absence.Excused);
        }


        [Test]
        public void IsAbsenceExist_ShouldReturnTrueIfAbsenceExist()
        {
            var absence = service.IsAbsenceExist(1).Result;

            Assert.AreEqual(true, absence);
        }
    }
}
