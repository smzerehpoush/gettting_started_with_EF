using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace EFGetStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                db.Add(new BlogModel() {Url = "http://blogs.msdn.com/adonet"});
                db.SaveChanges();
                Console.WriteLine("new blog persisted.");

                var blog = db.Blogs.OrderBy(b => b.ID).First();
                Console.WriteLine($"found blog : {blog}");

                blog.Url = "https://new.edited.url";
                blog.Posts.Add(
                    new PostModel()
                    {
                        Title = "Hello World",
                        Content = "I wrote an app using EF Core!"
                    });
                Console.WriteLine("updating data");
                db.SaveChanges();

                // db.Remove(blog);
                // db.SaveChanges();
                // Console.WriteLine("blog removed successfully");
                
                db.
            }
        }
    }
}