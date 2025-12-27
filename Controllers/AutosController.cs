using Microsoft.AspNetCore.Mvc;
using App10_AppVentasAutos.Data;
using App10_AppVentasAutos.Models;

namespace App10_AppVentasAutos.Controllers
{
    public class AutosController : Controller
    {
        private readonly AppDbContext _context;

        public AutosController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var autos = _context.Autos.ToList();
            return View(autos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Auto auto)
        {
            if (ModelState.IsValid)
            {
                _context.Autos.Add(auto);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(auto);
        }
    }
}
