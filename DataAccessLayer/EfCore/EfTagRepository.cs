using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EfCore
{
    public class EfTagRepository : ITagRepository
    {
        private BlogContext blogContext;

        public EfTagRepository(BlogContext blogContext)
        {
            this.blogContext = blogContext;
        }

        public IQueryable<Tag> Tags => blogContext.Tags;

        public void CreateTag(Tag tag)
        {
            blogContext.Tags.Add(tag);
            blogContext.SaveChanges();
        }

        public async Task<List<Tag>> GetAllTagsAsync()
        {
            return await blogContext.Tags.ToListAsync();
        }
    }
}
