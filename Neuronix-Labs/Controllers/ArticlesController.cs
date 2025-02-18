using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class ArticlesController : Controller
    {
        // GET: ArticlesController
        public ActionResult Index()
        {
            return View();
        }

    }
}
