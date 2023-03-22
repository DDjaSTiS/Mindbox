using MindboxTest;
using System;
using Xunit;
using FluentAssertions;

namespace Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(5, Math.PI * 5 * 5)]
        public void CalculateArea_CircleWithRadiusGreaterThanZero_ReturnsAreaAsDouble(int radius, double expected)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            var result = circle.CalculateArea();

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(0, double.NaN)]
        [InlineData(-1, double.NaN)]
        public void CalculateArea_CircleWithRadiusLessOrEqualThanZero_ReturnsMinusOne(int radius, double expected)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            var result = circle.CalculateArea();

            // Assert
            result.Should().Be(expected);
        }
    }
}