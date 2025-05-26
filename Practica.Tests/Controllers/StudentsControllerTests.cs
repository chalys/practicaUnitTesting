
using Moq;
using Practica.API.Controllers;
using Practica.API.Models;
using Practica.API.Services;
using Xunit;

namespace Practica.Tests.Controllers
{
    public class StudentsControllerTests
    {
        
        
[Fact]
public void HasApproved_WhenStudentExistsAndHasApproved_ReturnsTrue()
{
    // Arrange
    var studentId = 3;
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