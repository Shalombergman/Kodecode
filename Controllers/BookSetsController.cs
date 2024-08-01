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
    public class BookSetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookSetsController(ApplicationDbContext context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
            return View(await _context.BookSets.ToListAsync());
        }

       
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookSet = await _context.BookSets
                .FirstOrDefaultAsync(m => m.SetID == id);
            if (bookSet == null)
            {
                return NotFound();
            }

            return View(bookSet);
        }

  
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SetID,SetName")] BookSet bookSet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookSet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookSet);
        }

       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookSet = await _context.BookSets.FindAsync(id);
            if (bookSet == null)
            {
                return NotFound();
            }
            return View(bookSet);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SetID,SetName")] BookSet bookSet)
        {
            if (id != bookSet.SetID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookSet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookSetExists(bookSet.SetID))
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
            return View(bookSet);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookSet = await _context.BookSets
                .FirstOrDefaultAsync(m => m.SetID == id);
            if (bookSet == null)
            {
                return NotFound();
            }

            return View(bookSet);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookSet = await _context.BookSets.FindAsync(id);
            if (bookSet != null)
            {
                _context.BookSets.Remove(bookSet);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookSetExists(int id)
        {
            return _context.BookSets.Any(e => e.SetID == id);
        }
    }
}
