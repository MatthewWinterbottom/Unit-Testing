using Blog.Controllers;
using Blog.Models.ViewModels;
using Blog.Tests.BlogTests;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Tests
{
    public class GettingBlogs : BlogControllerTest
    {
        private IEnumerable<BlogViewModel> Blogs;

        [OneTimeSetUp]
        public void SetUp()
        {
            Blogs = BlogController.Get();
        }

        [Test]
        public void BlogCollectionIsNotNull()
        {
            Blogs.Should().NotBeNull();
        }

        [Test]
        public void BlogCollectionDoesNotContainNulls()
        {
            Blogs.Should().NotContainNulls();
        }

        [Test]
        public void BlogDatesAreCorrect()
        {
            Blogs.Select(blog => blog.DateCreated).Should();
        }
    }
}