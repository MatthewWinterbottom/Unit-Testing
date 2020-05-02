using Blog.Repository.DbModels;
using Blog.Repository.Interfaces;
using System.Collections.Generic;

namespace Blog.Services
{
    public class ReadBlogsService : IDbReadService<BlogEntity>
    {
        private readonly IBlogDbContext blogDbContext;
        public ReadBlogsService(IBlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }

        public IEnumerable<BlogEntity> GetAll() =>
            blogDbContext.Blogs;
    }
}
