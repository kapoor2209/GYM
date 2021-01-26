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
    public class ExpTrainersController : Controller
    {
        private readonly GYMContext _context;

        public ExpTrainersController(GYMContext context)
        {
            _context = context;
        }

        // GET: ExpTrainers
        public async Task<IActionResult> Index()
        {
            var gYMContext = _context.ExpTrainer.Include(e => e.Exersice).Include(e => e.Trainer);
            return View(await gYMContext.ToListAsync());
        }

        // GET: ExpTrainers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expTrainer = await _context.ExpTrainer
                .Include(e => e.Exersice)
                .Include(e => e.Trainer)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (expTrainer == null)
            {
                return NotFound();
            }

            return View(expTrainer);
        }
        [Authorize]
        // GET: ExpTrainers/Create
        public IActionResult Create()
        {
            ViewData["ExersiceID"] = new SelectList(_context.Exersice, "ExcerciseID", "ExersiceName");
            ViewData["TrainerID"] = new SelectList(_context.Trainer, "TrainerID", "Trainername");
            return View();
        }

        // POST: ExpTrainers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TrainerID,ExersiceID")] ExpTrainer expTrainer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expTrainer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ExersiceID"] = new SelectList(_context.Exersice, "ExcerciseID", "ExcerciseID", expTrainer.ExersiceID);
            ViewData["TrainerID"] = new SelectList(_context.Trainer, "TrainerID", "TrainerID", expTrainer.TrainerID);
            return View(expTrainer);
        }

        // GET: ExpTrainers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expTrainer = await _context.ExpTrainer.FindAsync(id);
            if (expTrainer == null)
            {
                return NotFound();
            }
            ViewData["ExersiceID"] = new SelectList(_context.Exersice, "ExcerciseID", "ExersiceName", expTrainer.ExersiceID);
            ViewData["TrainerID"] = new SelectList(_context.Trainer, "TrainerID", "Trainername", expTrainer.TrainerID);
            return View(expTrainer);
        }

        // POST: ExpTrainers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TrainerID,ExersiceID")] ExpTrainer expTrainer)
        {
            if (id != expTrainer.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expTrainer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpTrainerExists(expTrainer.ID))
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
            ViewData["ExersiceID"] = new SelectList(_context.Exersice, "ExcerciseID", "ExcerciseID", expTrainer.ExersiceID);
            ViewData["TrainerID"] = new SelectList(_context.Trainer, "TrainerID", "TrainerID", expTrainer.TrainerID);
            return View(expTrainer);
        }
        [Authorize]
        // GET: ExpTrainers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expTrainer = await _context.ExpTrainer
                .Include(e => e.Exersice)
                .Include(e => e.Trainer)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (expTrainer == null)
            {
                return NotFound();
            }

            return View(expTrainer);
        }

        // POST: ExpTrainers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expTrainer = await _context.ExpTrainer.FindAsync(id);
            _context.ExpTrainer.Remove(expTrainer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpTrainerExists(int id)
        {
            return _context.ExpTrainer.Any(e => e.ID == id);
        }
    }
}
