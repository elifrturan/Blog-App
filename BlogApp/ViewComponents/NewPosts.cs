using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents
{
    public class NewPosts : ViewComponent
    {
        private IPostRepository postRepository;

        public NewPosts(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var last3Posts = await postRepository.GetLatest3PostsAsync();

            return View(last3Posts);
        }
    }
}
