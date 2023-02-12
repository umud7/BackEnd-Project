using BackEnd_Project.DAL;
using BackEnd_Project.Helpers.Extension;
using BackEnd_Project.Models;
using BackEnd_Project.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Documents;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Project.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index(string search)
        {
            var users=search==null ?
            _userManager.Users.ToList():
            _userManager.Users
            .Where(u=>u.FullName.ToLower().Contains(search.ToLower()))
            .ToList();

            return View(users);
        }

       public async Task<IActionResult>Update(string id)
        {
            AppUser user= await _userManager.FindByIdAsync(id);
            RoleVM roleVM = new RoleVM();
            roleVM.Roles =_roleManager.Roles.ToList();
            roleVM.UserRoles = await _userManager.GetRolesAsync(user);
            roleVM.UserId = user.Id;
            roleVM.FullName = user.FullName;

            return View(roleVM);
        }

        [HttpPost]

        public async Task<IActionResult> Update(string id,List<string>roles)
        {


            AppUser user = await _userManager.FindByIdAsync(id);
            var userRoles = await _userManager.GetRolesAsync(user);
           await _userManager.RemoveFromRolesAsync(user,userRoles);
            await _userManager.AddToRolesAsync(user, roles);

            return RedirectToAction("Index");
        }
        

    }
}
