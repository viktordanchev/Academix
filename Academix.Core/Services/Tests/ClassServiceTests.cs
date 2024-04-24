using Academix.Core.Contracts;
using Academix.Infrastructure.Data;
using NUnit.Framework;

namespace Academix.Core.Services.Tests
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

        [Test]
        public void GetClassIdAsync()
        {
            var teacher = "5093413e-4acb-471a-9ce7-53df30689fc1";
            var teacher2 = "6c1ff15b-1853-4d20-98ff-9695affb432c";
            var teacher3 = "bd3e68c0-728b-44a0-ba3a-992d8ae683f9";

            var classId = service.GetClassIdAsync(teacher);

            Assert.tr
        }
    }
}
