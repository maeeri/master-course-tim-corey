using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDemoLibrary;

namespace Homework25.Tests
{
    public class BuiltStringsTests
    {
        [Theory]
        [InlineData(new char[] { 'a', 'b' }, '.', "a.b")]
        [InlineData(new char[] { 'x', '9' }, 'e', "xe9")]
        [InlineData(new char[] { 'f', 'w', 'd' }, 'o', "fowod")]
        public void ShouldReturnString(char[] input, char separator, string expected)
        {
            // Arrange
            var builtString = new BuiltStrings();

            // Act
            var result = builtString.Build(input, separator);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
