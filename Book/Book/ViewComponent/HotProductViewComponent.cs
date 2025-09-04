using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Book.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var hotProducts = new List<string>
            {
                "Nồi cơm điện Nagakawa NAG0102",
                "Nồi cơm điện Sharp KS-TH18"
            };

            return View(hotProducts); // => tìm đến Default.cshtml
        }
    }
}
