using Blog.Controllers;
using Blog.IntegrationTests.HelperExtensionMethods;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using Xunit;

namespace Blog.IntegrationTests.BlogTests
{
    public class WhenGettingBlogs : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        public WhenGettingBlogs(WebApplicationFactory<Startup> factory)
        {
            this._factory = factory;
        }

        [InlineData(nameof(BlogController))]
        [Theory]

        public async Task BlogControllerReturnsSuccessStatusCode(string url)
        {
            // Arrange
            HttpClient client = _factory.CreateClient(); // Get HttpClient For Making HTTP Requests

            url = url.TrimControllerSuffix(); // Trim "Controller" off of the URL.

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
