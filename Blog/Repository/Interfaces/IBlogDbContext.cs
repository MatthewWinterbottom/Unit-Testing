using Blog.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repository.Interfaces
{
    public interface IBlogDbContext
    {
        public DbSet<DbModels.Blog> Blogs { get; }
        public DbSet<Author> Authors { get; }
    }
}
