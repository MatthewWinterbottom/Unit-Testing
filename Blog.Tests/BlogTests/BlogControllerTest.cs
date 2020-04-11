using Blog.Controllers;
using Blog.Repository.Interfaces;
using Blog.Services;
using Blog.Services.Interfaces;
using Blog.Tests.MockData;
using FluentAssertions;
using MockQueryable.NSubstitute;
using NSubstitute;
using NUnit.Framework;
using SimpleInjector;
using System.Linq;

namespace Blog.Tests.BlogTests
{
    public class BlogControllerTest
    {
        public BlogController BlogController { get; set; }

        [Test]
        public void BlogControllerIsNotNull()
        {
            BlogController.Should().NotBeNull();
        }

        [OneTimeSetUp]
        public void SetUpBlogController()
        {
            // Get DI container from Simple Injector
            var container = new Container();

            // Auto inject any concrete types we haven't explicitly registered
            container.Options.ResolveUnregisteredConcreteTypes = true;

            // Get Blog data as DbSet
            var blogData = MockDataBlogs
                                .GetBlogs()
                                .AsQueryable()
                                .BuildMockDbSet();

            // Mock Db Context
            var mockBlogDbContext = Substitute.For<IBlogDbContext>();

            // Set the retun value for Blogs Property
            mockBlogDbContext.Blogs.Returns(blogData);

            // Register IBlogDbContext with mockBlogDbContext, so we don't actually have to provide a DbContext
            container.Register<IBlogDbContext>(() => mockBlogDbContext);

            // Register the CRUD blogservice for the IBlogCRUDService
            container.Register<IBlogCRUDService, BlogCRUDService>();

            // Instiantiate BlogController
            BlogController = container.GetInstance<BlogController>();
        }
    }
}
