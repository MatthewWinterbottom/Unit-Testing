using System.Collections.Generic;

namespace Blog.Services
{
    public interface IDbReadService<Entity>
        where Entity : class
    {
        IEnumerable<Entity> GetAll();
    }
}
