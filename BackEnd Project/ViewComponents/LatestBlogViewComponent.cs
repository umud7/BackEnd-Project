using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Project.ViewComponents
{

    public class LatestBlogViewComponent:ViewComponent
    {

        private readonly AppDbContext _appDbContext;

        public LatestBlogViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<LatestBlog> latestBlogs = _appDbContext.LatestBlogs
                .ToList();

            return View(await Task.FromResult(latestBlogs));
        }

    }
}
