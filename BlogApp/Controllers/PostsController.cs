using BlogApp.Models;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class PostsController : Controller
    { 
        private IPostRepository _postRepository;

        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IActionResult Index()
        {
            var postViewModel = new PostViewModel
            {
                Posts = _postRepository.Posts.ToList(),
            };

            return View(postViewModel);
        }
    }
}
