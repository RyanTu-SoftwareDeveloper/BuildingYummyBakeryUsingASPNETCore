using Microsoft.AspNetCore.Mvc;

namespace YummyBakery.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
