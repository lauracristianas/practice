using PracticeProject;

namespace PracticeProjectTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int number1 = 5;
            int number2 = 2;
            int expectedVal = 10;

            // Act
            int actualVal = PracticeProject.Exercise1Class.Multiply(number1, number2);
            
            // Assert
            Assert.Equal(expectedVal, actualVal);
        }
    }
}