using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    public class BasicOperationsTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 2, 5)]
        [InlineData(3, 3, 6)]
        public void AddTest(double a, double b, double expected)
        {
            // Arrange
            var basicOperations = new BasicOperations();

            // Act
            var actual = basicOperations.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(3, 2, 1)]
        [InlineData(3, 3, 0)]
        public void SubtractTest(double a, double b, double expected)
        {
            // Arrange
            var basicOperations = new BasicOperations();

            // Act
            var actual = basicOperations.Subtract(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(3, 2, 6)]
        [InlineData(3, 3, 9)]
        public void MultiplyTest(double a, double b, double expected)
        {
            // Arrange
            var basicOperations = new BasicOperations();

            // Act
            var actual = basicOperations.Multiply(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(3, 2, 1.5)]
        [InlineData(3, 3, 1)]
        public void DivideTest(double a, double b, double expected)
        {
            // Arrange
            var basicOperations = new BasicOperations();

            // Act
            var actual = basicOperations.Divide(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExceptionsTest()
        {
            // Arrange
            var basicOperations = new BasicOperations();

            // Act and Assert
            Assert.Throws<DivideByZeroException>(() => basicOperations.Divide(1, 0));
            Assert.Throws<ArgumentException>(() => basicOperations.ValidateNumber("abc"));
        }
    }
}
