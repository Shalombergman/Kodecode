using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCBooksSystem.Data;
using MVCBooksSystem.Models;

namespace MVCBooksSystem.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Books.Include(b => b.BookSet).Include(b => b.Genre).Include(b => b.Shelv);
            return View(await applicationDbContext.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.BookSet)
                .Include(b => b.Genre)
                .Include(b => b.Shelv)
                .FirstOrDefaultAsync(m => m.BookID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

       
        public IActionResult Create()
        {
            ViewData["SetId"] = new SelectList(_context.BookSets, "SetID", "SetName");
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreID", "GenreName");
            ViewData["ShelvId"] = new SelectList(_context.Shelves, "ShelvId", "ShelvId");
            return View(new Book());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookID,Title,Author,Height,Width,GenreId,SetId,ShelvId")] int ShelvId, Book book)
        {
            if (ModelState.IsValid)
            {
                Shelv shelv = _context.Shelves.Find(ShelvId);
                Library library = _context.Libraries.Find(shelv.LibraryId);
                List<Book> books = _context.Books.Where(book => book.GenreId == library.GenreId && book.ShelvId == null && book.Height <= shelv.Height).ToList();
                foreach(Book book1 in books)
                {
                    if (book.Height > shelv.Height) throw new Exception("book not foundcan insert");

                    int totalWidth = books.Sum(book => book.Width) + book.Width;
                    if (totalWidth > shelv.Width) throw new Exception("book not can insert");

                    else 
                    {
                        
                        
                          if (book1 == book)
                          {
                               if (shelv.Height - book1.Height >= 10)
                               {

                                    TempData["Message"] = $"Warning: Excess space for book {book1.Title} on shelf {ShelvId}";
                                    TempData["MessageType"] = "warning";
                                }
                           _context.Add(book1);
                           await _context.SaveChangesAsync();
                           return RedirectToAction(nameof(Index));
                           }
                        



                    }
                }
                ViewData["ShelvId"] = new SelectList(_context.Set<Shelv>(), "Id", "Id", book.ShelvId);
                return View(book);




            }
            ViewData["SetId"] = new SelectList(_context.BookSets, "SetID", "SetName", book.SetId);
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreID", "GenreName", book.GenreId);
            ViewData["ShelvId"] = new SelectList(_context.Shelves, "ShelvId", "ShelvId", book.ShelvId);
            return View(book);
        }
        public bool CanAddBookToShelv(Book book, Shelv shelv, List<Book> booksOnShelv)
        {
            if (book.Height > shelv.Height) return false;
            int totalWidth = booksOnShelv.Sum(book => book.Width) + book.Width;
            if (totalWidth > shelv.Width) return false;
            return true;
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["SetId"] = new SelectList(_context.BookSets, "SetID", "SetName", book.SetId);
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreID", "GenreName", book.GenreId);
            ViewData["ShelvId"] = new SelectList(_context.Shelves, "ShelvId", "ShelvId", book.ShelvId);
            return View(book);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookID,Title,Author,Height,Width,GenreId,SetId,ShelvId")] Book book)
        {
            if (id != book.BookID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookID))
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
            ViewData["SetId"] = new SelectList(_context.BookSets, "SetID", "SetName", book.SetId);
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreID", "GenreName", book.GenreId);
            ViewData["ShelvId"] = new SelectList(_context.Shelves, "ShelvId", "ShelvId", book.ShelvId);
            return View(book);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.BookSet)
                .Include(b => b.Genre)
                .Include(b => b.Shelv)
                .FirstOrDefaultAsync(m => m.BookID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.BookID == id);
        }
    }
}
