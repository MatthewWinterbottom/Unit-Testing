using Blog.Mappings.ModelToViewModel;
using Blog.Models.ViewModels;
using Blog.Repository.DbModels;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IDbReadService<BlogEntity> blogCRUDService;
        public BlogController(IDbReadService<BlogEntity> blogCRUDService)
        {
            this.blogCRUDService = blogCRUDService;
        }

        [HttpGet]
        public IEnumerable<BlogViewModel> Get() =>
            blogCRUDService
                .GetAll()
                .GetBlogViewModel();
    }
}