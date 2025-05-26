using Moq;
using Practica.API.Controllers;
using Practica.API.Services;
using Xunit;

namespace Practica.API.Tests.Controllers.StudentsControllerTests.ApprovalTests
{
    public class HasApproved_WhenGradeLessThan51_ReturnsFalse
    {
        [Fact]
        public void Test()
        {
            // Arrange
            var studentId = 2;
            var mockService = new Mock<IStudentService>();
            mockService.Setup(s => s.HasApproved(studentId)).Returns(false);
            
            var controller = new StudentsController(mockService.Object);

            // Act
            var result = controller.HasApproved(studentId);

            // Assert
            Assert.False(result);
        }
    }
}