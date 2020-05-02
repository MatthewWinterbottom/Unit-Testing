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
            HttpClient client = _factory.CreateClient();

            url = url.GetControllerName();
            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();
        }
    }
}
