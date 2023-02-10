using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Project.Areas.AdminArea.Controllers
{
    public class DashboardController : Controller
    {
        [Area("AdminArea")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
