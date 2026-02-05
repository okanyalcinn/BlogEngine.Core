using Microsoft.AspNetCore.Mvc;

namespace BlogEngine.Core.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
