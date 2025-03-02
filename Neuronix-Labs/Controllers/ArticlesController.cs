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
    }
}
