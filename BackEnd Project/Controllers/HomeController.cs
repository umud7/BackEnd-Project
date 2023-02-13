﻿using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using BackEnd_Project.Services.Interfaces;
using BackEnd_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd_Project.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _appDbContext;
        private readonly ISum _service;

        public HomeController(AppDbContext appDbContext, ISum service)
        {
            this._appDbContext = appDbContext;
            _service = service;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Sliders = _appDbContext.Sliders.ToList();
            homeVM.NoticeBoards = _appDbContext.NoticeBoards.ToList();
            homeVM.Profs = _appDbContext.Profs.ToList();
            homeVM.Courses = _appDbContext.Courses.ToList();
            homeVM.Events = _appDbContext.Events.ToList();
            homeVM.Banners = _appDbContext.Banners.ToList();
            homeVM.LatestBlogs = _appDbContext.LatestBlogs.ToList();
            homeVM.Logo = _appDbContext.Logos.FirstOrDefault();

            //int result = _service.Sum(2, 3);

            return View(homeVM);
            
        }
    }
}
