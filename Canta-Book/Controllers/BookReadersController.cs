using Canta_Book.Data;
using Canta_Book.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Canta_Book.Controllers
{

    public class BookReadersController : Controller
    {

        private readonly ApplicationDbContext _context;

        public BookReadersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BookReaders
        public async Task<ActionResult> Index()
        {

            List<BookReader> lBookReader = await _context.BookReader
                .Include(m => m.User)
                .Include(m => m.Book)
                .ToListAsync();

            if (lBookReader is null)
            {
                return BadRequest();

            }

            return View(lBookReader);
        }

        public async Task<ActionResult> ManageBookReader()
        {
            List<BookReader> lBookReader = await _context.BookReader
                .ToListAsync();

            if (lBookReader is null)
            {
                return BadRequest();

            }

            return View(lBookReader);
        }

        // GET: BookReaders/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookReaders/Create
        public async Task<ActionResult> Create()
        {

            List<BookReader> lBookReader = await _context.BookReader
                .ToListAsync();
            List<User> lUser = await _context.User
                .ToListAsync();
            List<Book> lBook = await _context.Book
                .ToListAsync();

            ViewData["lBookReader"] = lBookReader;
            ViewData["lUser"] = lUser;
            ViewData["lBook"] = lBook;

            return View();
        }

        // POST: BookReaders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookReader bookReader)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _context.BookReader.Add(bookReader);
                    _context.SaveChanges();
                }

                return View(bookReader);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        // GET: BookReaders/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            BookReader? BookReader = await _context.BookReader
                .Where(m => m.BookReaderID == id)
                .FirstOrDefaultAsync();

            List<BookReader> lBookReader = await _context.BookReader
                .ToListAsync();

            ViewData["lBookReader"] = lBookReader;

            return View(BookReader);

        }

        // POST: BookReaders/Edit/5
        [HttpPost]
        public ActionResult Edit(BookReader bookReader)
        {
            try
            {
                _context.BookReader.Update(bookReader);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookReaders/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var bookReader = await _context.BookReader.SingleOrDefaultAsync(b => b.BookReaderID == id);
            try
            {
                if (bookReader is null)
                {
                    return NotFound();
                }

                _context.Remove(bookReader);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: BookReaders/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {

            return View();

        }


    }
}
