using Blog.Repository.DbModels;
using System;
using System.Collections.Generic;

namespace Blog.Tests.MockData
{
    public static class MockDataBlogs
    {

        public static IEnumerable<BlogEntity> GetBlogs()
        {
            return new[]
            {
                new BlogEntity
                {
                    Title = "You Are Not Good",
                    Author = new Author { Name = "Matthew Winterbottom" },
                    Snippet = "You are probably not good",
                    DateCreated = new DateTime(2020, 04, 11)
                },
                new BlogEntity
                {
                    Title = "We Shouldnt Have Left The EU",
                    Author = new Author { Name = "Carl Austin" },
                    Snippet = "Juncker was a top geezer, why did we ever leave the EU?",
                    DateCreated = new DateTime(2020, 04, 10)
                },
                new BlogEntity
                {
                    Title = "Let My Lovely Wife Stay In The Country",
                    Author = new Author { Name = "Liam Windsor Brown" },
                    Snippet = "The UK Visa process to get a God fearing Yankee into the Country is ridiculous.",
                    DateCreated = new DateTime(2020, 04, 09)
                },
            };
        }
    }
}
