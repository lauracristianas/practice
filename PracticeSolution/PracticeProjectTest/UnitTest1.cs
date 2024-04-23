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

        [Theory]
        [InlineData(6, 0, 0)]
        public void Test2(int number1, int number2, int expectedVal)
        {
            // Arrange
            // Act
            int actualVal = PracticeProject.Exercise1Class.Multiply(number1, number2);

            // Assert
            Assert.Equal(expectedVal, actualVal);
        }
    }
}