using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Project.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CategoryController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var categories = _appDbContext.Categories.ToList();
            _appDbContext.SaveChanges();

            return View(categories);
        }

        public async Task<IActionResult> Detail(int?id)
        {
            if (id == null) return NotFound();
            
            Category category = await _appDbContext.Categories.FindAsync(id);
            if(category == null) return NotFound();

            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid) return View();

            var isExist=_appDbContext.Categories
                .Any(c=> c.Name.ToLower()==category.Name.ToLower());


            if(isExist)
            {
                ModelState.AddModelError("Name", "this name already exist");
                return View();
            }

            _appDbContext.Categories.Add(category);

            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Update(int ? id)
        {
            if (id == null) return NotFound();
            Category category = _appDbContext.Categories.Find(id);
            if (category == null) return NotFound();

            return View(category);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(Category category)
        {
            if (!ModelState.IsValid) return View();

            Category existCategory=_appDbContext.Categories.Find(category.Id);

            var isExist = _appDbContext.Categories
               .Any(c => c.Name.ToLower() == category.Name.ToLower()&&c.Id!=category.Id);

            if (isExist)
            {
                ModelState.AddModelError("Name", "this name already exist");
                return View();

            }
            existCategory.Name = category.Name;
            existCategory.Desc = category.Desc;

            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Category category = _appDbContext.Categories.Find(id);
            if (category == null) return NotFound();

            return View(category);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteCategory(int? id)
        {
            if (id == null) return NotFound();
            Category category = _appDbContext.Categories.Find(id);
            if (category == null) return NotFound();
            _appDbContext.Categories.Remove(category);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
