﻿using Blog.Models.ViewModels;
using Blog.Repository.DbModels;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Mappings.ModelToViewModel
{
    public static class BlogMapping
    {
        public static IEnumerable<BlogViewModel> GetBlogViewModel(this IEnumerable<BlogEntity> blogs) =>
             blogs.Select(blog => new BlogViewModel
             {
                 Id = blog.Id,
                 Title = blog.Title,
                 DateCreated = blog.DateCreated.ToString("dd/MM/yyyy"),
                 Snippet = blog.Snippet,
                 Url = blog.Url,
                 AuthorName = blog.Author.Name
             });
    }
}
