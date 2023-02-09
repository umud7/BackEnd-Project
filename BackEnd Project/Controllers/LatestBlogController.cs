using BackEnd_Project.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BackEnd_Project.Controllers
{
    public class LatestBlogController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public LatestBlogController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            var blogs = _appDbContext.LatestBlogs
                        .Include(b => b.BlogImages)
                       .FirstOrDefault(b => b.Id == id);

            return View(blogs);
        }

    }
}
