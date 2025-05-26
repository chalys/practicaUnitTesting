using Moq;
using Practica.API.Controllers;
using Practica.API.Models;
using Practica.API.Services;
using Xunit;

namespace Practica.API.Tests.Controllers.StudentsControllerTests.GetByIdTests
{
    public class GetById_ReturnsCorrectID_AsCI
    {
        [Fact]
        public void test()
        {
            // Arrange - Given
            var expectedId = 1; // El ID actúa como CI
            var mockService = new Mock<IStudentService>();
            mockService.Setup(service => service.GetById(expectedId)).Returns(
                new Student 
                { 
                    Id = expectedId,
                    Name = "María González", 
                    Grade = 80 
                }
            );
            
            StudentsController controller = new StudentsController(mockService.Object);

            // Act - When
            var result = controller.GetById(expectedId);
            
            // Assert - Then
            Assert.Equal(expectedId, result.Id); // Validamos que el ID/CI sea correcto
        }
    }
}