using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
