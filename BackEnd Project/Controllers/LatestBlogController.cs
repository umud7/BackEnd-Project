using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Project.Controllers
{
    public class LatestBlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
