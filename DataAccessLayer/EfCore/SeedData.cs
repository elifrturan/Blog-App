using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EfCore
{
    public static class SeedData
    {
        public static void Initialize(BlogContext context)
        {
            if (!context.Tags.Any())
            {
                context.Tags.AddRange(
                    new Tag {  Text = "Web Programlama" },    
                    new Tag {  Text = "Backend" },    
                    new Tag {  Text = "Frontend" },    
                    new Tag {  Text = "Full Stack" },    
                    new Tag {  Text = "PHP" }    
                );
                context.SaveChanges();
            }

            if(!context.Users.Any())
            {
                context.Users.AddRange(
                    new User {  UserName = "sadikturan" },    
                    new User {  UserName = "ahmetyilmaz" }    
                );
                context.SaveChanges();
            }

            if (!context.Posts.Any())
            {
                context.Posts.AddRange(
                    new Post
                    {
                        Title = "Asp.Net Core Dersleri",
                        Content = "Asp.Net core ile 60 saat ders",
                        IsActive = true,
                        PublishedOn = DateTime.Now.AddDays(-10),
                        Tags = context.Tags.Take(3).ToList(),
                        UserID = 1
                    },
                     new Post
                     {
                         Title = "PHP Dersleri",
                         Content = "PHP ile 60 saat ders",
                         IsActive = true,
                         PublishedOn = DateTime.Now.AddDays(-20),
                         Tags = context.Tags.Take(2).ToList(),
                         UserID = 1
                     },
                      new Post
                      {
                          Title = "Django Dersleri",
                          Content = "Django ile 60 saat ders",
                          IsActive = true,
                          PublishedOn = DateTime.Now.AddDays(-5),
                          Tags = context.Tags.Take(5).ToList(),
                          UserID = 2
                      }
                );
                context.SaveChanges();
            }
        }
    }

}
