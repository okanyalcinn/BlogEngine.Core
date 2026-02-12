using Microsoft.AspNetCore.Mvc;

namespace BlogEngine.Core.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
