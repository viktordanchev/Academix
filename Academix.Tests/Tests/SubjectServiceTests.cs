using Academix.Core.Contracts;
using Academix.Core.Models.Subject;
using Academix.Core.Services;
using Academix.Infrastructure.Data;

namespace Academix.Tests.Tests
{
    public class SubjectServiceTests
    {
        private AcademixDbContext context;
        private ISubjectService service;
        private readonly string directorId = "a3717562-385e-41ce-9eff-0f1b994e5548";

        [SetUp]
        public void SetUp()
        {
            context = MockDatabase.Instance();
            service = new SubjectService(context);
        }

        [TearDown]
        public void TearDown()
        {
            context.Database.EnsureDeletedAsync();
        }

        [Test]
        public void GetSchoolIdAsync_ShouldReturnSchoolIdForDirector()
        {
            var schoolId = service.GetSchoolIdAsync(directorId).Result;

            Assert.AreEqual(1, schoolId);
        }

        [Test]
        public void GetSubjectsAsync_ShouldReturnCountOfSubjectsInSchool()
        {
            var subjects = service.GetSubjectsAsync(1).Result;

            Assert.AreEqual(3, subjects.Count());
        }

        [Test]
        public void GetTeachersAsync_ShouldReturnCountOfTeachersInSchool()
        {
            var teachers = service.GetTeachersAsync(1).Result;

            Assert.AreEqual(3, teachers.Count());
        }

        [Test]
        public void AddSubjectAsync_ShouldAddNewSubjectToSchool()
        {
            var subject = new AddSubjectViewModel()
            {
                Name = "Test",
                TeacherId = 4
            };

            service.AddSubjectAsync(1, subject);

            Assert.AreEqual(4, context.Subjects.Count());
        }

        [Test]
        public void IsTeacherHasSubject_ShouldReturnTrue()
        {
            Assert.IsTrue(service.IsTeacherHasSubject(1).Result);
            Assert.IsTrue(service.IsTeacherHasSubject(2).Result);
            Assert.IsTrue(service.IsTeacherHasSubject(3).Result);
        }

        [Test]
        public void IsTeacherExistInSchool_ShouldReturnTrue()
        {
            Assert.IsTrue(service.IsTeacherExistInSchool(1, 1).Result);
            Assert.IsTrue(service.IsTeacherExistInSchool(1, 2).Result);
            Assert.IsTrue(service.IsTeacherExistInSchool(1, 3).Result);
        }

        [Test]
        public void RemoveSubjectAsync_ShouldRemoveAllSubjects()
        {
            service.RemoveSubjectAsync(1);
            service.RemoveSubjectAsync(2);
            service.RemoveSubjectAsync(3);

            Assert.AreEqual(0, context.Subjects.Count());
        }

        [Test]
        public void IsSubjectExistAsync_ShouldReturnTrue()
        {
            Assert.IsTrue(service.IsSubjectExistAsync(1).Result);
            Assert.IsTrue(service.IsSubjectExistAsync(2).Result);
            Assert.IsTrue(service.IsSubjectExistAsync(3).Result);
        }
    }       
}
