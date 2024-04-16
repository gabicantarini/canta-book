using Canta_Book.Data;
using Canta_Book.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace Canta_Book.Controllers
{
     public class BooksController : Controller
    {

        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BooksController
        public async Task<ActionResult> Index(string message)
        {

            List<Book> lBook = await _context.Book
                .ToListAsync();

            if (lBook is null)
            {
                return BadRequest();

            }

            ViewBag.Message = message;

            return View(lBook);
        }

        // GET: BooksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BooksController/Create
        public async Task<ActionResult> Create()
        {

            List<Author> lAuthor = await _context.Author
                .ToListAsync();

            ViewData["lAuthor"] = lAuthor;

            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        public async Task<ActionResult> Create(Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //book.AuthorID = 1;
                    
                    _context.Book.Add(book);
                    _context.SaveChanges();
                }

                return View(book);

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        // GET: BooksController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            Book? book = await _context.Book
                .Where(m => m.BookID == id)
                .FirstOrDefaultAsync();

            List<Author> lAuthor = await _context.Author
                .ToListAsync();

            ViewData["lAuthor"] = lAuthor;

            return View(book);

        }

        // POST: BooksController/Edit/5
        [HttpPost]
        public ActionResult Edit(Book book)
        {
            try
            {
                _context.Book.Update(book);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index), new { message = "Sucesso !!!"});
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var book = await _context.Book.SingleOrDefaultAsync(b => b.BookID == id);

            try
            {
                if (book is null)
                {
                    return NotFound();
                }

                _context.Remove(book);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: BooksController/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {

           return View();
            
        }
    }
}
