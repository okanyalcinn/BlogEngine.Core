using Microsoft.AspNetCore.Mvc;

namespace BlogEngine.Core.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
