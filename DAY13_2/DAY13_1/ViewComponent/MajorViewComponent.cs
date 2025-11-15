using DAY13_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DAY13_1.ViewComponent
{
    public class MajorViewComponent : ViewComponent
    {
        SchoolContext db;
        List<Major> majors;

        public MajorViewComponent(SchoolContext _context)
        {
            db = _context;
            majors = db.Majors.ToList();
        }

        public async Task<IViewComponentResult> InvokeAsys()
        {
            return View("RenderMajor", majors);
        }
    }
}
