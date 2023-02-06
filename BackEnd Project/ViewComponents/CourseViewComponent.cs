using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewComponents
{


    public class CourseViewComponent : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public CourseViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Course> courses = _appDbContext.Courses
                .Take(take)
                .ToList();

            return View(await Task.FromResult(courses));
        }
    }
}
