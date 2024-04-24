using Academix.Core.Contracts;
using Academix.Core.Models.Student;
using Academix.Core.Services;
using Academix.Infrastructure.Data;

namespace Academix.Tests.Tests
{
    public class TeacherStudentServiceTests
    {
        private AcademixDbContext context;
        private ITeacherStudentService service;

        private readonly string teacherId = "5093413e-4acb-471a-9ce7-53df30689fc1";
        private readonly string teacher2Id = "6c1ff15b-1853-4d20-98ff-9695affb432c";

        [SetUp]
        public void SetUp()
        {
            context = MockDatabase.Instance();
            service = new TeacherStudentService(context);
        }

        [TearDown]
        public void TearDown()
        {
            context.Database.EnsureDeletedAsync();
        }

        [Test]
        public void GetStudentsAsync_ShouldReturnStudentsCountThatHasSubjectWithTeacher()
        {
            var students = service.GetStudentsAsync(1, teacherId).Result;
            var students2 = service.GetStudentsAsync(1, teacher2Id).Result;

            Assert.AreEqual(2, students.Count());
            Assert.AreEqual(1, students2.Count());
        }

        [Test]
        public void GetSchoolIdAsync_ShouldReturnSchoolIdThatCurrentTeacherItsIn()
        {
            var schoolId = service.GetSchoolIdAsync(teacherId).Result;
            var schoolId2 = service.GetSchoolIdAsync(teacher2Id).Result;

            Assert.AreEqual(1, schoolId);
            Assert.AreEqual(1, schoolId2);
        }


        [Test]
        public void AddGradeAsync_ShouldAddGradeCorrectly()
        {
            var grade = new AddGradeViewModel()
            {
                GradeNumber = 3,
                GradeType = 0,
                SubjectId = 1,
            };

            service.AddGradeAsync(1, grade);

            Assert.AreEqual(5, context.Grades.Count());
        }

        [Test]
        public void GetSubjectIdAsync_ShouldReturnTeacherSubjectId()
        {
            var subjectId = service.GetSubjectIdAsync(teacherId).Result;
            var subjectId2 = service.GetSubjectIdAsync(teacher2Id).Result;

            Assert.AreEqual(1, subjectId);
            Assert.AreEqual(2, subjectId2);
        }

        [Test]
        public void GetGradesAsync_ShouldReturnCountOfGradesInGivenSubject()
        {
            var grades = service.GetGradesAsync(1, 1).Result;
            var grades2 = service.GetGradesAsync(1, 2).Result;
            var grades3 = service.GetGradesAsync(2, 1).Result;

            Assert.AreEqual(2, grades.Count());
            Assert.AreEqual(1, grades2.Count());
            Assert.AreEqual(0, grades3.Count());
        }

        [Test]
        public void RemoveGradeAsync_ShouldRemoveGradeCorrectly()
        {
            service.RemoveGradeAsync(1);

            Assert.AreEqual(3, context.Grades.Count());
        }

        [Test]
        public void GetAbsencesAsync_ShouldReturnAbsencesCount()
        {
            var absences = service.GetAbsencesAsync(1, 1).Result;
            var absences2 = service.GetAbsencesAsync(1, 3).Result;

            Assert.AreEqual(2, absences.Count());
            Assert.AreEqual(0, absences2.Count());
        }

        [Test]
        public void AddAbsenceAsync_ShouldAddAbsence()
        {
            service.AddAbsenceAsync(1, 1);
            service.AddAbsenceAsync(1, 1);
            service.AddAbsenceAsync(1, 3);

            Assert.AreEqual(6, context.Absences.Count());
        }

        [Test]
        public void RemoveAbsenceAsync_ShouldRemoveAbsence()
        {
            service.RemoveAbsenceAsync(4);
            service.RemoveAbsenceAsync(5);
            service.RemoveAbsenceAsync(6);

            Assert.AreEqual(3, context.Absences.Count());
        }

        [Test]
        public void IsAbsenceItsForSubject_ShouldReturnTrue()
        {
            Assert.IsTrue(service.IsAbsenceItsForSubject(1, 1).Result);
            Assert.IsTrue(service.IsAbsenceItsForSubject(2, 1).Result);
            Assert.IsTrue(service.IsAbsenceItsForSubject(3, 2).Result);
        }

        [Test]
        public void IsGradeItsForSubject_ShouldReturnTrue()
        {
            Assert.IsTrue(service.IsGradeItsForSubject(1, 1).Result);
            Assert.IsTrue(service.IsGradeItsForSubject(2, 1).Result);
            Assert.IsTrue(service.IsGradeItsForSubject(3, 2).Result);
            Assert.IsTrue(service.IsGradeItsForSubject(4, 3).Result);
        }
    }
}
