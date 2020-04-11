using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.DbModels;

namespace Blog.DbModels
{
    public class Blog
    {
        public int Id { get; set; }
        public Author Author { get; set; }
        public string Title { get; set; }
        public string Snippet { get; set; }
        public DateTime DateCreated { get; set; }
        public string Url { get; set; }
    }
}
