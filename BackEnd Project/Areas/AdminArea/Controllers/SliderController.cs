using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace BackEnd_Project.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderController : Controller 
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext appDbContext, IWebHostEnvironment env)
        {
            _appDbContext = appDbContext;
            _env = env;
        }

        public IActionResult Index()
        {
            var sliders = _appDbContext.Sliders.ToList();
            _appDbContext.SaveChanges();

            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Slider slider)
        {
            if (ModelState["Photo"].ValidationState==Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if(!slider.Photo.ContentType.Contains("image"))
            {
                ModelState.AddModelError("Photo", "shekil Sech");
            }
            if(slider.Photo.Length/1024>100)
            {
                ModelState.AddModelError("Photo", "Olchu Boyuktu");
            }


            string fileName = Guid.NewGuid() + slider.Photo.FileName;
            string path = Path.Combine(_env.WebRootPath, "img/slider",fileName);


            using(FileStream stream = new FileStream(path, FileMode.Create))
            {
                slider.Photo.CopyTo(stream);
            }
            Slider newSlider = new Slider();
            newSlider.ImageUrl = fileName;
            newSlider.Photo = slider.Photo;
            newSlider.Title = slider.Title;
            newSlider.SecondTitle = slider.SecondTitle;
            newSlider.Desc=slider.Desc;
            _appDbContext.Sliders.Add(newSlider);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
