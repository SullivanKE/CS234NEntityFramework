using CS234NEntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CS234NEntityFramework.Data;

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
        [HttpPost]
        public IActionResult Index(AppUser u)
        {
            AppUser? user = _context.AppUsers.FirstOrDefault(u => u.Name == u.Name);
            ViewData["AppConfig"] = _context.AppConfigs.FirstOrDefault();
            if (user != null && u.Password == user.Password) // I'm not going to do any kind of encryption here, but I understand saving plain passwords is a bad idea.
            {
                ViewData["Nav"] = RoleNav.GetRoleNav(user.Role);

                return View(user);
            }
            else
                return View();
            
        }
    }
}
