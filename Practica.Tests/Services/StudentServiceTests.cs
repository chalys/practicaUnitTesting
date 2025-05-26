using Practica.API.Models;
using Practica.API.Services;
using Xunit;

namespace Practica.API.Tests
{
    public class StudentServiceTests
    {
        private readonly StudentService _studentService;

        public StudentServiceTests()
        {
            _studentService = new StudentService();
        }

        [Fact]
        public void HasApproved_WhenGradeIsGreaterThanOrEqualTo51_ReturnsTrue()
        {
            // Arrange
            var studentId = 1; // Juan Pérez tiene nota 85

            // Act
            var result = _studentService.HasApproved(studentId);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void HasApproved_WhenGradeIsLessThan51_ReturnsFalse()
        {
            // Arrange
            var studentId = 2; // María García tiene nota 45

            // Act
            var result = _studentService.HasApproved(studentId);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GetById_ReturnsCorrectStudent()
        {
            // Arrange
            var studentId = 1;
            var expectedName = "Juan Pérez";
            var expectedGrade = 85;

            // Act
            var result = _studentService.GetById(studentId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedName, result.Name);
            Assert.Equal(expectedGrade, result.Grade);
        }
    }
}