using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wejobr.Models;

namespace Wejobr.Controllers
{
    public class CandidatoesController : Controller
    {
        private readonly Context _context;

        public CandidatoesController(Context context)
        {
            _context = context;
        }

        // GET: Candidatoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.candidatos.ToListAsync());
        }

        // GET: Candidatoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidato = await _context.candidatos
                .FirstOrDefaultAsync(m => m.Id_candidato == id);
            if (candidato == null)
            {
                return NotFound();
            }

            return View(candidato);
        }

        // GET: Candidatoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Candidatoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_candidato,Nome_candidato,Nascimento_candidato,Estado_civil_candidato,Nacionalidade_candidato,Rne_candidato,Idioma_candidato,Email_candidato,Senha_candidato,Cargo1_candidato,Cargo2_candidato,Cargo3_candidato")] Candidato candidato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(candidato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(candidato);
        }

        // GET: Candidatoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidato = await _context.candidatos.FindAsync(id);
            if (candidato == null)
            {
                return NotFound();
            }
            return View(candidato);
        }

        // POST: Candidatoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_candidato,Nome_candidato,Nascimento_candidato,Estado_civil_candidato,Nacionalidade_candidato,Rne_candidato,Idioma_candidato,Email_candidato,Senha_candidato,Cargo1_candidato,Cargo2_candidato,Cargo3_candidato")] Candidato candidato)
        {
            if (id != candidato.Id_candidato)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(candidato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandidatoExists(candidato.Id_candidato))
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
            return View(candidato);
        }

        // GET: Candidatoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidato = await _context.candidatos
                .FirstOrDefaultAsync(m => m.Id_candidato == id);
            if (candidato == null)
            {
                return NotFound();
            }

            return View(candidato);
        }

        // POST: Candidatoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var candidato = await _context.candidatos.FindAsync(id);
            _context.candidatos.Remove(candidato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CandidatoExists(int id)
        {
            return _context.candidatos.Any(e => e.Id_candidato == id);
        }
    }
}
