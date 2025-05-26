using Moq;
using Practica.API.Controllers;
using Practica.API.Services;
using Xunit;

namespace Practica.API.Tests.Controllers.StudentsControllerTests.ApprovalTests
{
    public class HasApproved_WhenGradeGreaterThan51_ReturnsTrue
    {
        [Fact]
        public void Test()
        {
            // Arrange
            var studentId = 1;
            var mockService = new Mock<IStudentService>();
            mockService.Setup(s => s.HasApproved(studentId)).Returns(true);
            
            var controller = new StudentsController(mockService.Object);

            // Act
            var result = controller.HasApproved(studentId);

            // Assert
            Assert.True(result);
        }
    }
}