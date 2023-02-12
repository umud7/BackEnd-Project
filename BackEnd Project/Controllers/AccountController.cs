using BackEnd_Project.Helpers;
using BackEnd_Project.Models;
using BackEnd_Project.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BackEnd_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if(!ModelState.IsValid) return View();

            AppUser user = new AppUser()
            {
                UserName = register.UserName,
                Email = register.Email,
                FullName = register.FullName
            };

            
            IdentityResult result = await _userManager.CreateAsync(user, register.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }

            await _userManager.AddToRoleAsync(user, RolesEnum.Admin.ToString());

            return RedirectToAction("Login");
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult>Login(LoginVM login,string ReturnUrl)
        {
            if (!ModelState.IsValid) return View();


            AppUser user = await _userManager.FindByEmailAsync(login.Email);
            if (user == null)
            {
                ModelState.AddModelError("","email ve yaxud password sehvdir");
                return View(login);
            }
           var result=await _signInManager.PasswordSignInAsync(user, login.Password, login.RememberMe, true);

            if(result.IsLockedOut)
            {
                ModelState.AddModelError("", "hesab bloklanib");
                return View(login);
            }
            if(result.Succeeded)
            {
                ModelState.AddModelError("", "email ve yaxud password sehvdir");
                return View(login);
            }

            await _signInManager.SignInAsync(user, login.RememberMe);

            var isAdminRole = await _userManager.IsInRoleAsync(user, RolesEnum.Admin.ToString());

           
                if (isAdminRole)
                {
                    return RedirectToAction("Index", "Dashboard", new {area="AdminArea"});
                }
            

            if (ReturnUrl!=null)
            {
                return Redirect(ReturnUrl);
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        //public async Task<IActionResult>AddRoles()
        //{
        //    foreach (var role in Enum.GetValues(typeof(RolesEnum)))
        //    {
        //        if (!await _roleManager.RoleExistsAsync(role.ToString()))
        //        {
        //            await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
        //        }
        //    }
        //    return Content("role elave olundu");
        //}

    }
}
