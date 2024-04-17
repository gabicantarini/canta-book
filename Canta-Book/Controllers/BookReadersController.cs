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

        // GET: BookReaders/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookReaders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookReaders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookReaders/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookReaders/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookReaders/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }


    }
}
