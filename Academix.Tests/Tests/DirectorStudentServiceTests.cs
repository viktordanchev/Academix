using Academix.Core.Contracts;
using Academix.Core.Services;
using Academix.Infrastructure.Data;

namespace Academix.Tests.Tests
{
    [TestFixture]
    public class DirectorStudentServiceTests
    {
        private AcademixDbContext context;
        private IDirectorStudentService service;

        [SetUp]
        public void SetUp()
        {
            context = MockDatabase.Instance();
            service = new DirectorStudentService(context);
        }

        [TearDown]
        public void TearDown()
        {
            context.Database.EnsureDeletedAsync();
        }

        [Test]
        public void GetStudentsAsync_ShouldReturnStudentsCountFromCurrentSchool()
        {
            var students = service.GetStudentsAsync(1).Result;
            var students2 = service.GetStudentsAsync(12).Result;

            Assert.AreEqual(3, students.Count());
            Assert.AreEqual(0, students2.Count());
        }

        [Test]
        public void AddSubjectStudentAsync_ShouldAddSubjectStudentCorrectly()
        {
            service.AddSubjectStudentAsync(2, 2);

            Assert.IsTrue(service.IsStudentHasSubjectAsync(2, 2).Result);
            Assert.AreEqual(5, context.SubjectsStudents.Count());
        }

        [Test]
        public void IsStudentFromSchoolAsync_ShouldReturnTrue()
        {
            Assert.IsTrue(service.IsStudentFromSchoolAsync(1, 1).Result);
            Assert.IsTrue(service.IsStudentFromSchoolAsync(2, 1).Result);
        }

        [Test]
        public void IsSubjectFromSchoolAsync_ShouldReturnTrue()
        {
            Assert.IsTrue(service.IsSubjectFromSchoolAsync(1, 1).Result);
            Assert.IsTrue(service.IsSubjectFromSchoolAsync(2, 1).Result);
            Assert.IsTrue(service.IsSubjectFromSchoolAsync(3, 1).Result);
        }

        [Test]
        public void IsStudentHasSubjectAsync_ShouldReturnTrue()
        {
            Assert.IsTrue(service.IsStudentHasSubjectAsync(1, 1).Result);
            Assert.IsTrue(service.IsStudentHasSubjectAsync(1, 2).Result);
            Assert.IsTrue(service.IsStudentHasSubjectAsync(1, 3).Result);
            Assert.IsTrue(service.IsStudentHasSubjectAsync(2, 1).Result);
        }

        [Test]
        public void RemoveSubjectStudentAsync_ShouldRemoveSubjectFromStudent()
        {
            service.RemoveSubjectStudentAsync(1, 1);
            service.RemoveSubjectStudentAsync(2, 1);

            Assert.IsFalse(service.IsStudentHasSubjectAsync(1, 1).Result);
            Assert.IsFalse(service.IsStudentHasSubjectAsync(1, 2).Result);
            Assert.AreEqual(2, context.SubjectsStudents.Count());
        }

        [Test]
        public void GetStudentNameAsync_ShouldReturnStudentName()
        {
            var student = service.GetStudentNameAsync(1).Result;
            var student2 = service.GetStudentNameAsync(2).Result;
            var student3 = service.GetStudentNameAsync(3).Result;

            Assert.AreEqual("Mitko-Marinov", student);
            Assert.AreEqual("Drago-Kirilov", student2);
            Assert.AreEqual("Marta-Kirilova", student3);
        }
    }
}
