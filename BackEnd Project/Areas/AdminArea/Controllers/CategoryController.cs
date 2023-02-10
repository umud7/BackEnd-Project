using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Project.Areas.AdminArea.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
