namespace EFGetStarted
{
    public class PostModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public BlogModel Blog { get; set; }
    }
}