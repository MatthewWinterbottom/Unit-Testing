﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DbModels
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Blog> Blogs { get; set; } = new HashSet<Blog>();
    }
}
