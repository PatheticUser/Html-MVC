using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Neuronix_Labs.Models;
using Neuronix_Labs.Models.ViewModels; // Ensure this matches the correct namespace
using System.Linq;
using System.Threading.Tasks;

namespace Neuronix_Labs.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArticlesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Articles
        public IActionResult Index()
        {
            var articles = _context.Articles.ToList();
            var model = new ArticleViewModel { Articles = articles };
            return View(model);
        }

        // GET: Articles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Articles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Category,Title,Description")] Article article)
        {
            if (ModelState.IsValid)
            {
                _context.Add(article);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(article);
        }
    }
}
