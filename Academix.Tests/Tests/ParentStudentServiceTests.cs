using Academix.Core.Contracts;
using Academix.Core.Services;
using Academix.Infrastructure.Data;

namespace Academix.Tests.Tests
{
    public class ParentStudentServiceTests
    {
        private AcademixDbContext context;
        private IParentStudentService service;
        private readonly string parentId = "24a0fdf5-ca4f-4c0f-8120-f6c87448033c";
        private readonly string parent2Id = "925da918-5cd0-4b17-9b62-2f417aac0343";

        [SetUp]
        public void SetUp()
        {
            context = MockDatabase.Instance();
            service = new ParentStudentService(context);
        }

        [TearDown]
        public void TearDown()
        {
            context.Database.EnsureDeletedAsync();
        }

        [Test]
        public void GetStudentsInfoAsync_ShouldReturnStudentsCount()
        {
            var students = service.GetStudentsInfoAsync(parentId).Result;
            var students2 = service.GetStudentsInfoAsync(parent2Id).Result;

            Assert.AreEqual(2, students.Count());
            Assert.AreEqual(1, students2.Count());
        }
    }
}
