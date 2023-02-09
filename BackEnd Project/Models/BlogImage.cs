using System.Reflection.Metadata;

namespace BackEnd_Project.Models
{
    public class BlogImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public LatestBlog LatestBlog { get; set; }
    }
}
