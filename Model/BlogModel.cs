using System.Collections.Generic;

namespace EFGetStarted
{
    public class BlogModel
    {

        public int ID { get; set; }
        public string Url { get; set; }

        public List<PostModel> Posts { get; } = new List<PostModel>();        
    }
}