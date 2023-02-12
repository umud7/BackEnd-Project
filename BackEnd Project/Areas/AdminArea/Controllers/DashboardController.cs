using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Project.Areas.AdminArea.Controllers
{
    public class DashboardController : Controller
    {
        [Area("AdminArea")]
        //[Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
