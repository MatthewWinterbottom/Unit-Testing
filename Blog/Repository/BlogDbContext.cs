using System;
using Blog.DbModels;
using Blog.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Blog.Repository
{
    public class BlogDbContext : DbContext, IBlogDbContext
    {

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
            Blogs = Set<DbModels.Blog>();
            Authors = Set<Author>();
        }

        public DbSet<DbModels.Blog> Blogs { get; }
        public DbSet<Author> Authors { get; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=WinterbottomsPC;Database=MatthewWinterbottomBlog; Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DbModels.Blog>(b =>
            {
                b.HasKey(b => b.Id);

                b.HasOne(b => b.Author)
                    .WithMany(a => a.Blogs)
                    .IsRequired();

                b.Property(b => b.Title)
                    .HasMaxLength(255)
                    .IsRequired();

                b.Property(b => b.DateCreated)
                    .IsRequired()
                    .HasDefaultValue(DateTime.Now);

                b.Property(b => b.DateCreated)
                    .IsRequired();

                b.Property(b => b.Url)
                    .IsRequired();
            });

            modelBuilder.Entity<Author>(a =>
            {
                a.HasKey(a => a.Id);

                a.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsRequired();
            });
        }
    }
}
