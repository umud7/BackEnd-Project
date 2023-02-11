using BackEnd_Project.DAL;
using BackEnd_Project.Helpers.Extension;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BackendProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment env;

        public CourseController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            this.env = env;
        }

        public IActionResult Index()
        {
            var courses = _context.Courses
                .Include(c => c.CourseDetail)
                .Include(c => c.CourseImages)
                .Include(c => c.CourseCategory)
                .ThenInclude(c => c.Category)
                .ToList();
            return View(courses);
        }
        public IActionResult Create()
        {

            ViewBag.Categories = new SelectList(_context.Categories.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Course course, CourseDetail courseDetail)
        {
            ViewBag.Categories = new SelectList(_context.Categories.ToList(), "Id", "Name");
            if (!ModelState.IsValid) return View();

            Course newCourse = new Course();

            newCourse.CourseImages = new List<CourseImage>();
            foreach (var item in course.Photos)
            {
                if (!item.CheckImage())
                {
                    ModelState.AddModelError("Photos", "shekil sech");
                    return View();
                }
                if (item.CheckImageSize(300))
                {
                    ModelState.AddModelError("Photos", "Olchu boyukdur");
                    return View();

                }

                CourseImage image = new CourseImage();
                if (item == course.Photos[0])
                {
                    image.IsMain = true;
                }

                image.ImageUrl = item.SaveImage(env, "img/course");
                newCourse.CourseImages.Add(image);
            }

            newCourse.Name = course.Name;
            newCourse.Desc = course.Desc;
            newCourse.CourseDetail.Apply = course.CourseDetail.Apply;
            newCourse.CourseDetail.Certification = course.CourseDetail.Certification;
            newCourse.CourseDetail.About = course.CourseDetail.About;
            newCourse.Photos = course.Photos;
            newCourse.CourseDetail.CourseId = courseDetail.CourseId;
          




            _context.Courses.Add(newCourse);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}