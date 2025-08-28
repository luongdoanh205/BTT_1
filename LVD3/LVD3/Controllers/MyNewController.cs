using Microsoft.AspNetCore.Mvc;

namespace LVD3.Controllers
{
    public class MyNewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sample()
        {
            return View();
        }
    }
}
