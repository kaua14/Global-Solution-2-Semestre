using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Global_Solution.Models;

namespace Global_Solution.Controllers
{
    public class cy_feedbacksController : Controller
    {
        private readonly OracleDBContext _context;

        public cy_feedbacksController(OracleDBContext context)
        {
            _context = context;
        }

        // GET: cy_feedbacks
        public async Task<IActionResult> Index()
        {
              return _context.cy_Feedbacks != null ? 
                          View(await _context.cy_Feedbacks.ToListAsync()) :
                          Problem("Entity set 'OracleDBContext.cy_Feedbacks'  is null.");
        }

        // GET: cy_feedbacks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.cy_Feedbacks == null)
            {
                return NotFound();
            }

            var cy_feedbacks = await _context.cy_Feedbacks
                .FirstOrDefaultAsync(m => m.IdFeedback == id);
            if (cy_feedbacks == null)
            {
                return NotFound();
            }

            return View(cy_feedbacks);
        }

        // GET: cy_feedbacks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: cy_feedbacks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFeedback,comentario,classificacao")] cy_feedbacks cy_feedbacks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cy_feedbacks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cy_feedbacks);
        }

        // GET: cy_feedbacks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.cy_Feedbacks == null)
            {
                return NotFound();
            }

            var cy_feedbacks = await _context.cy_Feedbacks.FindAsync(id);
            if (cy_feedbacks == null)
            {
                return NotFound();
            }
            return View(cy_feedbacks);
        }

        // POST: cy_feedbacks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFeedback,comentario,classificacao")] cy_feedbacks cy_feedbacks)
        {
            if (id != cy_feedbacks.IdFeedback)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cy_feedbacks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!cy_feedbacksExists(cy_feedbacks.IdFeedback))
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
            return View(cy_feedbacks);
        }

        // GET: cy_feedbacks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.cy_Feedbacks == null)
            {
                return NotFound();
            }

            var cy_feedbacks = await _context.cy_Feedbacks
                .FirstOrDefaultAsync(m => m.IdFeedback == id);
            if (cy_feedbacks == null)
            {
                return NotFound();
            }

            return View(cy_feedbacks);
        }

        // POST: cy_feedbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.cy_Feedbacks == null)
            {
                return Problem("Entity set 'OracleDBContext.cy_Feedbacks'  is null.");
            }
            var cy_feedbacks = await _context.cy_Feedbacks.FindAsync(id);
            if (cy_feedbacks != null)
            {
                _context.cy_Feedbacks.Remove(cy_feedbacks);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool cy_feedbacksExists(int id)
        {
          return (_context.cy_Feedbacks?.Any(e => e.IdFeedback == id)).GetValueOrDefault();
        }
    }
}
