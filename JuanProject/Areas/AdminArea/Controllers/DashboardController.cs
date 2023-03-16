using JuanProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace JuanProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public DashboardController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View(_appDbContext.Categories.ToList());
        }
    }
}
