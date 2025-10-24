using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lvd_231230725_de02.Models;

namespace lvd_231230725_de02.Controllers
{
    public class LvdCatalogsController : Controller
    {
        private readonly LvdContext _context;

        public LvdCatalogsController(LvdContext context)
        {
            _context = context;
        }

        // GET: LvdCatalogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.LvdCatalogs.ToListAsync());
        }

        // GET: LvdCatalogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lvdCatalog = await _context.LvdCatalogs
                .FirstOrDefaultAsync(m => m.LvdId == id);
            if (lvdCatalog == null)
            {
                return NotFound();
            }

            return View(lvdCatalog);
        }

        // GET: LvdCatalogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LvdCatalogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LvdId,LvdCateName,LvdCatePrice,LvdCateQty,LvdPicture,LvdCateActive")] LvdCatalog lvdCatalog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lvdCatalog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lvdCatalog);
        }

        // GET: LvdCatalogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lvdCatalog = await _context.LvdCatalogs.FindAsync(id);
            if (lvdCatalog == null)
            {
                return NotFound();
            }
            return View(lvdCatalog);
        }

        // POST: LvdCatalogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LvdId,LvdCateName,LvdCatePrice,LvdCateQty,LvdPicture,LvdCateActive")] LvdCatalog lvdCatalog)
        {
            if (id != lvdCatalog.LvdId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lvdCatalog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LvdCatalogExists(lvdCatalog.LvdId))
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
            return View(lvdCatalog);
        }

        // GET: LvdCatalogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lvdCatalog = await _context.LvdCatalogs
                .FirstOrDefaultAsync(m => m.LvdId == id);
            if (lvdCatalog == null)
            {
                return NotFound();
            }

            return View(lvdCatalog);
        }

        // POST: LvdCatalogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lvdCatalog = await _context.LvdCatalogs.FindAsync(id);
            if (lvdCatalog != null)
            {
                _context.LvdCatalogs.Remove(lvdCatalog);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LvdCatalogExists(int id)
        {
            return _context.LvdCatalogs.Any(e => e.LvdId == id);
        }
    }
}
