using Blog.Mappings.ModelToViewModel;
using Blog.Models.ViewModels;
using Blog.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly ICRUDService blogCRUDService;
        public BlogController(ICRUDService blogCRUDService)
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