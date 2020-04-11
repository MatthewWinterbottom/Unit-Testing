using FluentAssertions;
using Xunit;

namespace Blog.IntegrationTests.HelperExtensionMethods
{
    public class WheTrimmingControllerSuffix
    {

        [Fact]
        public void TheControllerSuffixIsRemoved()
        {
            // Arrange
            var testString = "testController";

            // Act
            var resultString = testString.TrimControllerSuffix();

            // Assert
            resultString.Should().Be("test");
        }

        [Fact]
        public void TheNullInputReturnsNull()
        {
            // Arrange
            string nullString = null;

            // Act
            var result = nullString.TrimControllerSuffix();

            // Assert
            result.Should().Be(nullString);
        }

        [Fact]
        public void TheEmptyStringReturnsAnEmptyString()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var result = emptyString.TrimControllerSuffix();

            // Assert
            result.Should().Be(emptyString);
        }

        [Fact]
        public void TheStringWithoutControllerReturnsTheString()
        {
            // Arrange
            string cowboyGreeting = "Howdy Partner!";

            // Act
            string result = cowboyGreeting.TrimControllerSuffix();

            // Assert
            result.Should().Be(cowboyGreeting);
        }
    }
}
