using BackEnd_Project.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BackEnd_Project.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public EventController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var events = _appDbContext.Events.ToList();
            return View(events);
        }

        public IActionResult Detail(int id)
        {
            var events = _appDbContext.EventDetails.Include(e=>e.Event).FirstOrDefault();
            return View(events);

        }
    }
}
