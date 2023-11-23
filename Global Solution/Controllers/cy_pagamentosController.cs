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
    public class cy_pagamentosController : Controller
    {
        private readonly OracleDBContext _context;

        public cy_pagamentosController(OracleDBContext context)
        {
            _context = context;
        }

        // GET: cy_pagamentos
        public async Task<IActionResult> Index()
        {
              return _context.cy_Pagamentos != null ? 
                          View(await _context.cy_Pagamentos.ToListAsync()) :
                          Problem("Entity set 'OracleDBContext.cy_Pagamentos'  is null.");
        }

        // GET: cy_pagamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.cy_Pagamentos == null)
            {
                return NotFound();
            }

            var cy_pagamentos = await _context.cy_Pagamentos
                .FirstOrDefaultAsync(m => m.IdPagamento == id);
            if (cy_pagamentos == null)
            {
                return NotFound();
            }

            return View(cy_pagamentos);
        }

        // GET: cy_pagamentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: cy_pagamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPagamento,valor,dataPagamento,status,informacoesCartao")] cy_pagamentos cy_pagamentos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cy_pagamentos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cy_pagamentos);
        }

        // GET: cy_pagamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.cy_Pagamentos == null)
            {
                return NotFound();
            }

            var cy_pagamentos = await _context.cy_Pagamentos.FindAsync(id);
            if (cy_pagamentos == null)
            {
                return NotFound();
            }
            return View(cy_pagamentos);
        }

        // POST: cy_pagamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPagamento,valor,dataPagamento,status,informacoesCartao")] cy_pagamentos cy_pagamentos)
        {
            if (id != cy_pagamentos.IdPagamento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cy_pagamentos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!cy_pagamentosExists(cy_pagamentos.IdPagamento))
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
            return View(cy_pagamentos);
        }

        // GET: cy_pagamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.cy_Pagamentos == null)
            {
                return NotFound();
            }

            var cy_pagamentos = await _context.cy_Pagamentos
                .FirstOrDefaultAsync(m => m.IdPagamento == id);
            if (cy_pagamentos == null)
            {
                return NotFound();
            }

            return View(cy_pagamentos);
        }

        // POST: cy_pagamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.cy_Pagamentos == null)
            {
                return Problem("Entity set 'OracleDBContext.cy_Pagamentos'  is null.");
            }
            var cy_pagamentos = await _context.cy_Pagamentos.FindAsync(id);
            if (cy_pagamentos != null)
            {
                _context.cy_Pagamentos.Remove(cy_pagamentos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool cy_pagamentosExists(int id)
        {
          return (_context.cy_Pagamentos?.Any(e => e.IdPagamento == id)).GetValueOrDefault();
        }
    }
}
