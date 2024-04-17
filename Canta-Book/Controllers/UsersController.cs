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
        public async Task<IActionResult> Index()
        {
            List<User> lUser = await _context.User    
                .ToListAsync();

            if (lUser is null)
            {
                return BadRequest();

            }

            return View(lUser);
        }

        public async Task<IActionResult> ManageUsers()
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
        public async Task<IActionResult> Create()
        {
           
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _context.User.Add(user);
                    _context.SaveChanges();
                }
                return View(user);
            }
            catch (Exception ex)
            {
                throw;
            }
 


        }


        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            User? user = await _context.User
                .Where(m => m.UserID == id)
                .FirstOrDefaultAsync();
            if (id == null)
            {
                return NotFound();
            }

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch 
                {
                    return View();
                }
                
            }
            return View();
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.UserID == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            return View();
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.UserID == id);
        }
    }
}
