﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using atendimento_aluno.Models;

namespace atendimento_aluno.Controllers
{
    public class AtendimentoesController : Controller
    {
        private readonly Contexto _context;

        public AtendimentoesController(Contexto context)
        {
            _context = context;
        }

        // GET: Atendimentoes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Atendimento.ToListAsync());
        }

        // GET: Atendimentoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Atendimento == null)
            {
                return NotFound();
            }

            var atendimento = await _context.Atendimento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atendimento == null)
            {
                return NotFound();
            }

            return View(atendimento);
        }

        // GET: Atendimentoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Atendimentoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataAtendimento,HoraAtendimento")] Atendimento atendimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(atendimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(atendimento);
        }

        // GET: Atendimentoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Atendimento == null)
            {
                return NotFound();
            }

            var atendimento = await _context.Atendimento.FindAsync(id);
            if (atendimento == null)
            {
                return NotFound();
            }
            return View(atendimento);
        }

        // POST: Atendimentoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataAtendimento,HoraAtendimento")] Atendimento atendimento)
        {
            if (id != atendimento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(atendimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtendimentoExists(atendimento.Id))
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
            return View(atendimento);
        }

        // GET: Atendimentoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Atendimento == null)
            {
                return NotFound();
            }

            var atendimento = await _context.Atendimento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atendimento == null)
            {
                return NotFound();
            }

            return View(atendimento);
        }

        // POST: Atendimentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Atendimento == null)
            {
                return Problem("Entity set 'Contexto.Atendimento'  is null.");
            }
            var atendimento = await _context.Atendimento.FindAsync(id);
            if (atendimento != null)
            {
                _context.Atendimento.Remove(atendimento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtendimentoExists(int id)
        {
          return _context.Atendimento.Any(e => e.Id == id);
        }
    }
}
