using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        [Fact]
        public void Greeting_WhenBeforeNoon_ReturnsGoodMorning()
        {
            // Arrange
            var messages = new DisplayMessages();
            var firstName = "John";
            var hourOfTheDay = 11;
            string expected = "Good Morning John";

            // Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Greeting_WhenAfterNoon_ReturnsGoodAfternoon()
        {
            // Arrange
            var messages = new DisplayMessages();
            var firstName = "John";
            var hourOfTheDay = 13;
            string expected = "Good Afternoon John";

            // Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Greeting_WhenAfterFive_ReturnsGoodEvening()
        {
            // Arrange
            var messages = new DisplayMessages();
            var firstName = "John";
            var hourOfTheDay = 18;
            string expected = "Good Evening John";

            // Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("John", 0, "Good Morning John")]
        [InlineData("John", 1, "Good Morning John")]
        [InlineData("John", 2, "Good Morning John")]
        [InlineData("John", 3, "Good Morning John")]
        [InlineData("John", 4, "Good Morning John")]
        [InlineData("John", 5, "Good Morning John")]
        [InlineData("John", 6, "Good Morning John")]
        [InlineData("John", 7, "Good Morning John")]
        [InlineData("John", 8, "Good Morning John")]
        [InlineData("John", 9, "Good Morning John")]
        [InlineData("John", 10, "Good Morning John")]
        [InlineData("John", 11, "Good Morning John")]
        [InlineData("John", 12, "Good Afternoon John")]
        [InlineData("John", 13, "Good Afternoon John")]
        [InlineData("John", 14, "Good Afternoon John")]
        [InlineData("John", 15, "Good Afternoon John")]
        [InlineData("John", 16, "Good Afternoon John")]
        [InlineData("John", 17, "Good Afternoon John")]
        [InlineData("John", 18, "Good Evening John")]
        [InlineData("John", 19, "Good Evening John")]
        [InlineData("John", 20, "Good Evening John")]
        [InlineData("John", 21, "Good Evening John")]
        [InlineData("John", 22, "Good Evening John")]
        [InlineData("John", 23, "Good Evening John")]
        public void Greeting_ShouldReturnExpectedValue(
            string firstName, 
            int hourOfTheDay, 
            string expected)
        {
            // Arrange
            var messages = new DisplayMessages();

            // Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
