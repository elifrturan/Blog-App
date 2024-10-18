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
    public class EfPostRepository : IPostRepository
    {
        private BlogContext blogContext;
        public EfPostRepository(BlogContext context)
        {
            blogContext = context;
        }
        public IQueryable<Post> Posts => blogContext.Posts;

        public void CreatePost(Post post)
        {
            blogContext.Posts.Add(post);
            blogContext.SaveChanges();
        }

        public async Task<List<Post>> GetLatest3PostsAsync()
        {
            return await blogContext.Posts
                .OrderByDescending(p => p.PublishedOn)
                .Take(3)
                .ToListAsync();
        }
    }
}
