using BackEnd_Project.Models;
using System.Collections.Generic;

namespace BackEnd_Project.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public List<Prof> Profs { get; set; }
        public List<Course> Courses { get; set; }
        public List<Event> Events { get; set; }
        public List<Banner> Banners { get; set; }
    }
}
