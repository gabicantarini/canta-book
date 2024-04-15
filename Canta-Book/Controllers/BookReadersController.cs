using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Canta_Book.Controllers
{
    public class BookReadersController : Controller
    {
        // GET: BookReaders
        public ActionResult Index()
        {
            return View();
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
        [ValidateAntiForgeryToken]
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

        // POST: BookReaders/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
