using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCBooksSystem.Data;
using MVCBooksSystem.Models;

namespace MVCBooksSystem.Controllers
{
    public class ShelvsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShelvsController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Shelves.Include(s => s.Library);
            return View(await applicationDbContext.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shelv = await _context.Shelves
                .Include(s => s.Library)
                .FirstOrDefaultAsync(m => m.ShelvId == id);
            if (shelv == null)
            {
                return NotFound();
            }

            return View(shelv);
        }

        
        public IActionResult Create()
        {
            ViewData["LibraryId"] = new SelectList(_context.Libraries, "LibraryID", "LibraryID");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShelvId,Height,Width,LibraryId")] Shelv shelv)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shelv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LibraryId"] = new SelectList(_context.Libraries, "LibraryID", "LibraryID", shelv.LibraryId);
            return View(shelv);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shelv = await _context.Shelves.FindAsync(id);
            if (shelv == null)
            {
                return NotFound();
            }
            ViewData["LibraryId"] = new SelectList(_context.Libraries, "LibraryID", "LibraryID", shelv.LibraryId);
            return View(shelv);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShelvId,Height,Width,LibraryId")] Shelv shelv)
        {
            if (id != shelv.ShelvId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shelv);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShelvExists(shelv.ShelvId))
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
            ViewData["LibraryId"] = new SelectList(_context.Libraries, "LibraryID", "LibraryID", shelv.LibraryId);
            return View(shelv);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shelv = await _context.Shelves
                .Include(s => s.Library)
                .FirstOrDefaultAsync(m => m.ShelvId == id);
            if (shelv == null)
            {
                return NotFound();
            }

            return View(shelv);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shelv = await _context.Shelves.FindAsync(id);
            if (shelv != null)
            {
                _context.Shelves.Remove(shelv);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShelvExists(int id)
        {
            return _context.Shelves.Any(e => e.ShelvId == id);
        }
    }
}
