﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Blog.Services.Interfaces
{
    public interface IBlogCRUDService
    {
        IEnumerable<DbModels.Blog> GetAll();
    }
}
