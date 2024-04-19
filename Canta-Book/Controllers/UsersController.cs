using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Canta_Book.Data;
using Canta_Book.Models;

namespace Canta_Book.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<ActionResult> Index()
        {
            List<User> lUser = await _context.User    
                .ToListAsync();

            if (lUser is null)
            {
                return BadRequest();

            }

            return View(lUser);
        }

        public async Task<ActionResult> ManageUsers()
        {
            List<User> lUser = await _context.User
                .ToListAsync();

            if (lUser is null)
            {
                return BadRequest();

            }

            return View(lUser);
        }



        // GET: Users/Create
        public async Task<ActionResult> Create()
        {
            List<User> lUser = await _context.User
                .ToListAsync();

            ViewData["lUser"] = lUser;

            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public async Task<ActionResult> Create(User user)
        {

            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }


        // GET: Users/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            User? user = await _context.User
                .Where(m => m.UserID == id)
                .FirstOrDefaultAsync();

            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(User user)
        {

            try
            {
                _context.User.Update(user);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }

        // GET: Users/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            var user = await _context.User.SingleOrDefaultAsync(b => b.UserID == id);

            try
            {
                if (user is null)
                {
                    return NotFound();
                }

                _context.Remove(user);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.UserID == id);
        }
    }
}
