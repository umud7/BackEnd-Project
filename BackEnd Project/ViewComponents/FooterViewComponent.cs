using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {

        private readonly AppDbContext _appDbContext;

        public FooterViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio footer = _appDbContext.Bio.FirstOrDefault();

            return View(await Task.FromResult(footer));
        }
    }
}
