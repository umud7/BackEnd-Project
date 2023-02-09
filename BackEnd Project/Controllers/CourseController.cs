using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BackEnd_Project.Controllers
{

    public class CourseController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CourseController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            var course = _appDbContext.Courses
                .Include(c => c.CourseTags).ThenInclude(c => c.Tag)
                .Include(c => c.CourseDetail)
               .FirstOrDefault(x=>x.Id==id);

            return View(course);
        }

    }

   
}
