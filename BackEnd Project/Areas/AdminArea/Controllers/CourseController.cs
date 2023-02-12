using BackEnd_Project.DAL;
using BackEnd_Project.Helpers.Extension;
using BackEnd_Project.Models;
using BackEnd_Project.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
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

        public IActionResult Index(int page=1,int take=3)
        {
            var courses = _context.Courses
                .Include(c => c.CourseDetail)
                .Include(c => c.CourseImages)
                .Include(c => c.CourseCategory)
                .ThenInclude(c => c.Category)
                .Skip((page-1)*take)
                .Take(take)
                .ToList();

           var courseCount = courses.Count();

           var items = courses.Skip((page-1)*take).Take(take).ToList();

            PaginationVM<Course> pagination = new PaginationVM<Course>(page, CalculatePageCount(courseCount,take), items);

            return View(courses);
        }

        private int CalculatePageCount(int count,int take)
        {
            return (int)Math.Ceiling((decimal)count / take);
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
            newCourse.Photos = course.Photos;
           newCourse.CourseDetail = courseDetail;




            _context.Courses.Add(newCourse);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}