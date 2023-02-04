using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {

        private readonly AppDbContext _appDbContext;

        public HeaderViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio header = _appDbContext.Bio.FirstOrDefault();

            return View(await Task.FromResult(header));
        }

    }
}
