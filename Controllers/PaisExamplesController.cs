using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GeomidisSystem.Context;
using GeomidisSystem.Models;

namespace GeomidisSystem.Controllers
{
    public class PaisExamplesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaisExamplesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PaisExamples
        public async Task<IActionResult> Index()
        {
            return _context.paisExamples != null ?
                        View(await _context.paisExamples.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.paisExamples'  is null.");
        }

        // GET: PaisExamples/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.paisExamples == null)
            {
                return NotFound();
            }

            var paisExample = await _context.paisExamples
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paisExample == null)
            {
                return NotFound();
            }

            return View(paisExample);
        }

        // GET: PaisExamples/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaisExamples/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CANBEN,CANBEN2,CANBEN3,CANBEN4,CANBEN5")] PaisExample paisExample)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paisExample);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paisExample);
        }

        // GET: PaisExamples/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.paisExamples == null)
            {
                return NotFound();
            }

            var paisExample = await _context.paisExamples.FindAsync(id);
            if (paisExample == null)
            {
                return NotFound();
            }
            return View(paisExample);
        }

        // POST: PaisExamples/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CANBEN,CANBEN2,CANBEN3,CANBEN4,CANBEN5")] PaisExample paisExample)
        {
            if (id != paisExample.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paisExample);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaisExampleExists(paisExample.Id))
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
            return View(paisExample);
        }

        // GET: PaisExamples/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.paisExamples == null)
            {
                return NotFound();
            }

            var paisExample = await _context.paisExamples
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paisExample == null)
            {
                return NotFound();
            }

            return View(paisExample);
        }

        // POST: PaisExamples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.paisExamples == null)
            {
                return Problem("Entity set 'ApplicationDbContext.paisExamples'  is null.");
            }
            var paisExample = await _context.paisExamples.FindAsync(id);
            if (paisExample != null)
            {
                _context.paisExamples.Remove(paisExample);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaisExampleExists(int id)
        {
            return (_context.paisExamples?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
