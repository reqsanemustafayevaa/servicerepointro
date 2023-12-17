using examprojectpr.Data.DAL;
using examprojectprc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace examprojectprc.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbcontext _context;
        public HomeController(AppDbcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Sliders = _context.Sliders.ToList(),
            };
            return View(homeViewModel);
        }
    }
}
