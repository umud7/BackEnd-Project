using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewComponents
{
    public class BannerViewComponent : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public BannerViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Banner> banners = _appDbContext.Banners
                .ToList();

            return View(await Task.FromResult(banners));
        }
    }
}
