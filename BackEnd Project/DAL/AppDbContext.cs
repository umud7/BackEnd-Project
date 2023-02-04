using BackEnd_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BackEnd_Project.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
          
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<Prof> Profs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<LatestBlog> LatestBlogs { get; set; }
        public DbSet<Bio> Bio { get; set; }
        public DbSet<Logo> Logos { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SocialPage> SocialPages { get; set; }
    }
}
