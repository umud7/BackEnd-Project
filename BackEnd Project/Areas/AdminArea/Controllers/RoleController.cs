using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Project.Controllers
{
    [Area("AdminArea")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View(_roleManager.Roles.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(string role)
        {
            await _roleManager.CreateAsync(new IdentityRole { Name = role });
            return RedirectToAction("index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _roleManager.DeleteAsync(_roleManager.Roles.FirstOrDefault(x=>x.Id==id));
            return RedirectToAction("index");
        }

    }
}
