﻿using BackEnd_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Project.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
          
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<Prof> Profs { get; set; }
    }
}
