using Microsoft.AspNetCore.Mvc;
using MeuSiteEmMVC.Data;
using MeuSiteEmMVC.Models;

namespace MeuSiteEmMVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly Connection _context;

        public UsersController(Connection context)
        {
            _context = context;
        }

        public IActionResult Index() => View(_context.Users.ToList());

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
    }
}
