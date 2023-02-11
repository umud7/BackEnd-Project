using BackEnd_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Project.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Register(RegisterVM register)
        {
            if(!ModelState.IsValid) return View();
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

       

    }
}
