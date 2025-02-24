using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Neuronix_Labs.Models;
using System.Threading.Tasks;

namespace Neuronix_Labs.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var services = await _context.Services.ToListAsync();
            return View(services);
        }
    }
}
