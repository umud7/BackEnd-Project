using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Project.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
