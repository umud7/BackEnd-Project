using BackEnd_Project.DAL;
using BackEnd_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewComponents
{

    public class NoticeBoardViewComponent : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public NoticeBoardViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<NoticeBoard> noticeBoards = _appDbContext.NoticeBoards
                .ToList();
            return View(await Task.FromResult(noticeBoards));
        }
    }
}
