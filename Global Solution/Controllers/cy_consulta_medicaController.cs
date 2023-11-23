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
    public class cy_consulta_medicaController : Controller
    {
        private readonly OracleDBContext _context;

        public cy_consulta_medicaController(OracleDBContext context)
        {
            _context = context;
        }

        // GET: cy_consulta_medica
        public async Task<IActionResult> Index()
        {
              return _context.cy_ConsultaMedica != null ? 
                          View(await _context.cy_ConsultaMedica.ToListAsync()) :
                          Problem("Entity set 'OracleDBContext.cy_ConsultaMedica'  is null.");
        }

        // GET: cy_consulta_medica/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.cy_ConsultaMedica == null)
            {
                return NotFound();
            }

            var cy_consulta_medica = await _context.cy_ConsultaMedica
                .FirstOrDefaultAsync(m => m.IdConsulta == id);
            if (cy_consulta_medica == null)
            {
                return NotFound();
            }

            return View(cy_consulta_medica);
        }

        // GET: cy_consulta_medica/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: cy_consulta_medica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdConsulta,IdPaciente,dataConsulta,sintomas,descricao,diagnostico,prescricao,status")] cy_consulta_medica cy_consulta_medica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cy_consulta_medica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cy_consulta_medica);
        }

        // GET: cy_consulta_medica/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.cy_ConsultaMedica == null)
            {
                return NotFound();
            }

            var cy_consulta_medica = await _context.cy_ConsultaMedica.FindAsync(id);
            if (cy_consulta_medica == null)
            {
                return NotFound();
            }
            return View(cy_consulta_medica);
        }

        // POST: cy_consulta_medica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdConsulta,IdPaciente,dataConsulta,sintomas,descricao,diagnostico,prescricao,status")] cy_consulta_medica cy_consulta_medica)
        {
            if (id != cy_consulta_medica.IdConsulta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cy_consulta_medica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!cy_consulta_medicaExists(cy_consulta_medica.IdConsulta))
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
            return View(cy_consulta_medica);
        }

        // GET: cy_consulta_medica/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.cy_ConsultaMedica == null)
            {
                return NotFound();
            }

            var cy_consulta_medica = await _context.cy_ConsultaMedica
                .FirstOrDefaultAsync(m => m.IdConsulta == id);
            if (cy_consulta_medica == null)
            {
                return NotFound();
            }

            return View(cy_consulta_medica);
        }

        // POST: cy_consulta_medica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.cy_ConsultaMedica == null)
            {
                return Problem("Entity set 'OracleDBContext.cy_ConsultaMedica'  is null.");
            }
            var cy_consulta_medica = await _context.cy_ConsultaMedica.FindAsync(id);
            if (cy_consulta_medica != null)
            {
                _context.cy_ConsultaMedica.Remove(cy_consulta_medica);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool cy_consulta_medicaExists(int id)
        {
          return (_context.cy_ConsultaMedica?.Any(e => e.IdConsulta == id)).GetValueOrDefault();
        }
    }
}
