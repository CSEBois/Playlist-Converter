using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Playlist_Converter.Data;
using Playlist_Converter.Models;

namespace Playlist_Converter.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }


        //Need to get the index to get the account page to pull up using index
        // GET: Account
        public async Task<IActionResult> Index()
        {
            return View(await _context.AccountModel.ToListAsync());
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        // GET: Account/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountModel = await _context.AccountModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (accountModel == null)
            {
                return NotFound();
            }

            return View(accountModel);
        }

        // GET: Account/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Email,Password")] AccountModel accountModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accountModel);
        }

        // GET: Account/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountModel = await _context.AccountModel.FindAsync(id);
            if (accountModel == null)
            {
                return NotFound();
            }
            return View(accountModel);
        }

        // POST: Account/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Email,Password")] AccountModel accountModel)
        {
            if (id != accountModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountModelExists(accountModel.ID))
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
            return View(accountModel);
        }

        // GET: Account/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountModel = await _context.AccountModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (accountModel == null)
            {
                return NotFound();
            }

            return View(accountModel);
        }

        // POST: Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accountModel = await _context.AccountModel.FindAsync(id);
            _context.AccountModel.Remove(accountModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountModelExists(int id)
        {
            return _context.AccountModel.Any(e => e.ID == id);
        }
    }
}
