using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BTTT7.Models;

namespace BTTT7.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly QLNhanVienContext _context;

        public NhanVienController(QLNhanVienContext context)
        {
            _context = context;
        }

        // GET: NhanVien
        public async Task<IActionResult> Index()
        {
            var qlnhanVienContext = _context.TChiTietNhanViens.Include(t => t.MaNvNavigation);
            return View(await qlnhanVienContext.ToListAsync());
        }

        // GET: NhanVien/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tChiTietNhanVien = await _context.TChiTietNhanViens
                .Include(t => t.MaNvNavigation)
                .FirstOrDefaultAsync(m => m.MaNv == id);
            if (tChiTietNhanVien == null)
            {
                return NotFound();
            }

            return View(tChiTietNhanVien);
        }

        // GET: NhanVien/Create
        public IActionResult Create()
        {
            ViewData["MaNv"] = new SelectList(_context.TNhanViens, "MaNv", "MaNv");
            return View();
        }

        // POST: NhanVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaNv,ChucVu,Hsluong,MucDoCv,Gtgc")] TChiTietNhanVien tChiTietNhanVien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tChiTietNhanVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaNv"] = new SelectList(_context.TNhanViens, "MaNv", "MaNv", tChiTietNhanVien.MaNv);
            return View(tChiTietNhanVien);
        }

        // GET: NhanVien/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tChiTietNhanVien = await _context.TChiTietNhanViens.FindAsync(id);
            if (tChiTietNhanVien == null)
            {
                return NotFound();
            }
            ViewData["MaNv"] = new SelectList(_context.TNhanViens, "MaNv", "MaNv", tChiTietNhanVien.MaNv);
            return View(tChiTietNhanVien);
        }

        // POST: NhanVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaNv,ChucVu,Hsluong,MucDoCv,Gtgc")] TChiTietNhanVien tChiTietNhanVien)
        {
            if (id != tChiTietNhanVien.MaNv)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tChiTietNhanVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TChiTietNhanVienExists(tChiTietNhanVien.MaNv))
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
            ViewData["MaNv"] = new SelectList(_context.TNhanViens, "MaNv", "MaNv", tChiTietNhanVien.MaNv);
            return View(tChiTietNhanVien);
        }

        // GET: NhanVien/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tChiTietNhanVien = await _context.TChiTietNhanViens
                .Include(t => t.MaNvNavigation)
                .FirstOrDefaultAsync(m => m.MaNv == id);
            if (tChiTietNhanVien == null)
            {
                return NotFound();
            }

            return View(tChiTietNhanVien);
        }

        // POST: NhanVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tChiTietNhanVien = await _context.TChiTietNhanViens.FindAsync(id);
            if (tChiTietNhanVien != null)
            {
                _context.TChiTietNhanViens.Remove(tChiTietNhanVien);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TChiTietNhanVienExists(string id)
        {
            return _context.TChiTietNhanViens.Any(e => e.MaNv == id);
        }
    }
}
