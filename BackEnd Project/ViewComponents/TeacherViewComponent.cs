using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewComponents
{
    public class TeacherViewComponent : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public TeacherViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Teacher> teachers = _appDbContext.Teachers
                .Include(t => t.SocialPage)
                .ToList();

            return View(await Task.FromResult(teachers));
        }
    }
}
