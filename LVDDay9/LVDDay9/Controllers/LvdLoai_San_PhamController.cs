using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LVDDay9.Models;

namespace LVDDay9.Controllers
{
    public class LvdLoai_San_PhamController : Controller
    {
        private readonly LVDDay9Context _context;

        public LvdLoai_San_PhamController(LVDDay9Context context)
        {
            _context = context;
        }

        // GET: LvdLoai_San_Pham
        public async Task<IActionResult> Index()
        {
            return View(await _context.LvdLoai_San_Pham.ToListAsync());
        }

        // GET: LvdLoai_San_Pham/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lvdLoai_San_Pham = await _context.LvdLoai_San_Pham
                .FirstOrDefaultAsync(m => m.lvdId == id);
            if (lvdLoai_San_Pham == null)
            {
                return NotFound();
            }

            return View(lvdLoai_San_Pham);
        }

        // GET: LvdLoai_San_Pham/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LvdLoai_San_Pham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("lvdId,lvdMaLoai,lvdTenLoai,lvdTrangThai")] LvdLoai_San_Pham lvdLoai_San_Pham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lvdLoai_San_Pham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lvdLoai_San_Pham);
        }

        // GET: LvdLoai_San_Pham/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lvdLoai_San_Pham = await _context.LvdLoai_San_Pham.FindAsync(id);
            if (lvdLoai_San_Pham == null)
            {
                return NotFound();
            }
            return View(lvdLoai_San_Pham);
        }

        // POST: LvdLoai_San_Pham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("lvdId,lvdMaLoai,lvdTenLoai,lvdTrangThai")] LvdLoai_San_Pham lvdLoai_San_Pham)
        {
            if (id != lvdLoai_San_Pham.lvdId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lvdLoai_San_Pham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LvdLoai_San_PhamExists(lvdLoai_San_Pham.lvdId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lvdLoai_San_Pham);
        }

        // GET: LvdLoai_San_Pham/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lvdLoai_San_Pham = await _context.LvdLoai_San_Pham
                .FirstOrDefaultAsync(m => m.lvdId == id);
            if (lvdLoai_San_Pham == null)
            {
                return NotFound();
            }

            return View(lvdLoai_San_Pham);
        }

        // POST: LvdLoai_San_Pham/Delete/5
        // POST: LvdLoai_San_Pham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            try
            {
                var lvdLoai_San_Pham = await _context.LvdLoai_San_Pham.FindAsync(id);

                if (lvdLoai_San_Pham == null)
                {
                    return NotFound();
                }

                _context.LvdLoai_San_Pham.Remove(lvdLoai_San_Pham);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // Log lỗi để debug
                Console.WriteLine($"Error deleting: {ex.Message}");
                return RedirectToAction(nameof(Index));
            }
        }

        private bool LvdLoai_San_PhamExists(long id)
        {
            return _context.LvdLoai_San_Pham.Any(e => e.lvdId == id);
        }
    }
}
