using Moq;
using Practica.API.Controllers;
using Practica.API.Models;
using Practica.API.Services;
using Xunit;

namespace Practica.API.Tests.Controllers.StudentsControllerTests.GetByIdTests
{
    public class GetById_ReturnsCorrectName
    {
        [Fact]
        public void Test()
        {
            // Arrange
            var studentId = 1;
            var expectedName = "María Rodríguez";
            var mockService = new Mock<IStudentService>();
            mockService.Setup(s => s.GetById(studentId))
                      .Returns(new Student { 
                          Id = studentId, 
                          Name = expectedName,
                          Grade = 80 
                      });
            
            var controller = new StudentsController(mockService.Object);

            // Act
            var result = controller.GetById(studentId);

            // Assert
            Assert.Equal(expectedName, result.Name);
        }
    }
}