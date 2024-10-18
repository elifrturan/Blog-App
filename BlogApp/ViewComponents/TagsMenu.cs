using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents
{
    public class TagsMenu : ViewComponent
    {
        private ITagRepository tagRepository;

        public TagsMenu(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var tags = await tagRepository.GetAllTagsAsync();

            return View(tags);
        }
    }
}
