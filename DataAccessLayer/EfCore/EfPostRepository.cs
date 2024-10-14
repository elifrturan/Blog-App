using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
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
    }
}
