using FluentAssertions;
using MindboxTest;
using Xunit;

namespace Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5, 6.0)]
        [InlineData(3, 3, 3, 3.897)]
        public void CalculateArea_ExistingTriangle_ReturnsAreaAsDouble(int sideA, int sideB, int sideC, double expected)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.CalculateArea();

            // Assert
            result.Should().BeApproximately(expected, 0.001);
        }

        [Theory]
        [InlineData(0, 0, 0, double.NaN)]
        [InlineData(0, 1, 2, double.NaN)]
        [InlineData(1, 2, 5, double.NaN)]
        public void CalculateArea_NotExistingTriangle_ReturnsMinusOne(int sideA, int sideB, int sideC, double expected)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.CalculateArea();

            // Assert
            result.Should().Be(expected);
        }
    }
}
