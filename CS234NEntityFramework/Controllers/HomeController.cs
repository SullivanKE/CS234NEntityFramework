using CS234NEntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace CS234NEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        BitsContext _context;
        public HomeController(BitsContext c) 
        {
            _context = c;
        }
        public IActionResult Index()
        {
            ViewData["AppConfig"] = _context.AppConfigs.FirstOrDefault();
            return View();
        }
    }
}
