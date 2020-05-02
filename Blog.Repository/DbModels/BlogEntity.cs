using System;

namespace Blog.Repository.DbModels
{
    public class BlogEntity
    {
        public int Id { get; set; }
        public Author Author { get; set; }
        public string Title { get; set; }
        public string Snippet { get; set; }
        public DateTime DateCreated { get; set; }
        public string Url { get; set; }
    }
}
