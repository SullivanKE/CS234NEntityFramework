namespace CS234NEntityFramework.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Role { get; set; }
        public AppUser Author { get; set; }

    }
}
