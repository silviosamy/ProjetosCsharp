using Microsoft.AspNetCore.Mvc;
using MeuSiteEmMVC.Data;
using MeuSiteEmMVC.Models;

namespace MeuSiteEmMVC.Controllers
{
    public class ProductsController : Controller
    {
<<<<<<< HEAD
        public IActionResult Index()
        {
            return View();
=======
        private readonly Connection _context;

        public ProductsController(Connection context)
        {
            _context = context;
        }

        public IActionResult Index() => View(_context.Products.ToList());

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
>>>>>>> 3df0da39a5325290ed31a0ea8e582449fed8c637
        }
    }
}
