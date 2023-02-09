using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BackEnd_Project.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public TeacherController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            var teacher = _appDbContext.Teachers
              .Include(t=>t.TeacherDetail).ThenInclude(t=>t.TeacherSkill)
             .FirstOrDefault();

            return View(teacher);
        }
    }
}
