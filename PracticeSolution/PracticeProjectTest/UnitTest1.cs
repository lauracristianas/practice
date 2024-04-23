using PracticeProject;

namespace PracticeProjectTest
{
    public class UnitTest1
    {
        [Theory]
        // testing normal numbers
        [InlineData(5, 2, 10)]
        [InlineData(2, 5, 10)]
        [InlineData(5, 1, 5)]
        [InlineData(1, 5, 5)]
        // testing zeros
        [InlineData(0, 6, 0)]
        [InlineData(6, 0, 0)]
        [InlineData(0, 0, 0)]
        // testing negatives
        [InlineData(5, -2, -10)]
        [InlineData(-2, 5, -10)]
        [InlineData(-2, -2, 4)]
        [InlineData(-9, 2, -18)]
        public void Test(int number1, int number2, int expectedVal)
        {
            // Arrange
            // Act
            int actualVal = PracticeProject.Exercise1Class.Multiply(number1, number2);

            // Assert
            Assert.Equal(expectedVal, actualVal);
        }
    }
}