using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {

        private readonly AppDbContext _appDbContext;
        private readonly UserManager<AppUser> _userManager;

        public HeaderViewComponent(AppDbContext appDbContext, UserManager<AppUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio header = _appDbContext.Bio.FirstOrDefault();

            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            }

            return View(await Task.FromResult(header));
        }

    }
}
