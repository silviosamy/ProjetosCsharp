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

<<<<<<< HEAD
        // GET: /Users
        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users); // procura Views/Users/Index.cshtml
        }

        // GET: /Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
=======
        public IActionResult Index() => View(_context.Users.ToList());

        public IActionResult Create() => View();

        [HttpPost]
>>>>>>> 3df0da39a5325290ed31a0ea8e582449fed8c637
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
