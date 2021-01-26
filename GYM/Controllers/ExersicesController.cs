using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GYM.Data;
using GYM.Models;
using Microsoft.AspNetCore.Authorization;

namespace GYM.Controllers
{
    public class ExersicesController : Controller
    {
        private readonly GYMContext _context;

        public ExersicesController(GYMContext context)
        {
            _context = context;
        }

        // GET: Exersices
        public async Task<IActionResult> Index()
        {
            return View(await _context.Exersice.ToListAsync());
        }

        // GET: Exersices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exersice = await _context.Exersice
                .FirstOrDefaultAsync(m => m.ExcerciseID == id);
            if (exersice == null)
            {
                return NotFound();
            }

            return View(exersice);
        }
        [Authorize]
        // GET: Exersices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Exersices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExcerciseID,ExersiceName,TimeDuration,Advantage,Disadvantage")] Exersice exersice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exersice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exersice);
        }

        // GET: Exersices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exersice = await _context.Exersice.FindAsync(id);
            if (exersice == null)
            {
                return NotFound();
            }
            return View(exersice);
        }

        // POST: Exersices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExcerciseID,ExersiceName,TimeDuration,Advantage,Disadvantage")] Exersice exersice)
        {
            if (id != exersice.ExcerciseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exersice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExersiceExists(exersice.ExcerciseID))
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
            return View(exersice);
        }
        [Authorize]
        // GET: Exersices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exersice = await _context.Exersice
                .FirstOrDefaultAsync(m => m.ExcerciseID == id);
            if (exersice == null)
            {
                return NotFound();
            }

            return View(exersice);
        }

        // POST: Exersices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exersice = await _context.Exersice.FindAsync(id);
            _context.Exersice.Remove(exersice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExersiceExists(int id)
        {
            return _context.Exersice.Any(e => e.ExcerciseID == id);
        }
    }
}
