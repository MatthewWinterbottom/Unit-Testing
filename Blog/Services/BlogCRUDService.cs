using Blog.Repository.Interfaces;
using Blog.Services.Interfaces;
using System.Collections.Generic;

namespace Blog.Services
{
    public class BlogCRUDService : IBlogCRUDService
    {
        private readonly IBlogDbContext blogDbContext;
        public BlogCRUDService(IBlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }

        public IEnumerable<DbModels.Blog> GetAll() => blogDbContext.Blogs;
    }
}
