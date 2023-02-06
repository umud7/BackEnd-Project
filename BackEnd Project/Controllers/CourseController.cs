using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Project.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
