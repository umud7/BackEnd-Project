using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Project.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
