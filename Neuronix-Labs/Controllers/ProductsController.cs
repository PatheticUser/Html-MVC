using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;
using System.Threading.Tasks;
using System.Linq;
using Neuronix_Labs.Models;

namespace MyApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();
            return View(product);
        }
    }
}
