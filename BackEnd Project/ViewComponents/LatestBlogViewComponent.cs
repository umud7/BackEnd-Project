using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<LatestBlog> latestBlogs = _appDbContext.LatestBlogs
                .Include(b => b.BlogImages)
                .Take(take)
                .ToList();

            return View(await Task.FromResult(latestBlogs));
        }

    }
}
