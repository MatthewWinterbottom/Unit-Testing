using Blog.Repository.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Blog.Repository.Interfaces
{
    public interface IBlogDbContext
    {
        public DbSet<BlogEntity> Blogs { get; }
        public DbSet<Author> Authors { get; }
    }
}
