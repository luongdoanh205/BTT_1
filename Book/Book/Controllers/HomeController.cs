using System.Diagnostics;
using Book.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Tạm dữ liệu cứng, thực tế sẽ lấy từ database
            var products = new List<string>
            {
                "Nồi cơm điện Nagakawa NAG0102",
                "Nồi cơm điện Sharp KS-TH18",
                "Nồi cơm điện Panasonic SR-PX184"
            };

            return View(products);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
