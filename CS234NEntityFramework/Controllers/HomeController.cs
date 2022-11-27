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
            ViewData["Posts"] = _context.Posts.Where(p => p.Role == "Client");
            return View();
        }
        [HttpPost]
        public IActionResult Index(AppUser userInput)
        {
            AppUser? user = _context.AppUsers.FirstOrDefault(userInput => userInput.Name == userInput.Name);
            ViewData["AppConfig"] = _context.AppConfigs.FirstOrDefault();
            if (user != null && userInput.Password == user.Password) // I'm not going to do any kind of encryption here, but I understand saving plain passwords is a bad idea.
            {
                ViewData["Nav"] = RoleNav.GetRoleNav(user.Role);
                ViewData["Posts"] = _context.Posts.ToList(); //TODO: Make this get posts based on roles

                return View(user);
            }
            else
                return View();
            
        }
    }
}
