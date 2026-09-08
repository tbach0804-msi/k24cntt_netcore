using Microsoft.AspNetCore.Mvc;

namespace Thblesson04.Controllers
{
    public class ThbAccountController : Controller
    {
        public IActionResult ThbIndex()
        {
            return View();
        }
    }
}
