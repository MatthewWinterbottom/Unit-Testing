using FluentAssertions;
using Xunit;

namespace Blog.IntegrationTests.HelperExtensionMethods
{
    public class WheTrimmingControllerSuffix
    {

        [Fact]
        public void TheControllerSuffixIsRemoved()
        {
            var testString = "testController";

            var resultString = testString.GetControllerName();

            resultString.Should().Be("test");
        }

        [Fact]
        public void TheNullInputReturnsNull()
        {
            string nullString = null;

            var result = nullString.GetControllerName();

            result.Should().Be(nullString);
        }

        [Fact]
        public void TheEmptyStringReturnsAnEmptyString()
        {
            var emptyString = string.Empty;

            var result = emptyString.GetControllerName();

            result.Should().Be(emptyString);
        }

        [Fact]
        public void TheStringWithoutControllerReturnsTheString()
        {
            string cowboyGreeting = "Howdy Partner!";

            string result = cowboyGreeting.GetControllerName();

            result.Should().Be(cowboyGreeting);
        }
    }
}
