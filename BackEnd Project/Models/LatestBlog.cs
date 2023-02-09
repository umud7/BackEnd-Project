using System;
using System.Collections.Generic;

namespace BackEnd_Project.Models
{
    public class LatestBlog
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string CommentScore { get; set; }
        public string Desc { get; set; }
        public List<BlogImage> BlogImages { get; set; }
    }
}
