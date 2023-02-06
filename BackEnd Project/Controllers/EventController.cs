using BackEnd_Project.DAL;
using Microsoft.AspNetCore.Mvc;
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
    }
}
