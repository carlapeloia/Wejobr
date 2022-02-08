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
    public class VagasController : Controller
    {
        private readonly Context _context;

        public VagasController(Context context)
        {
            _context = context;
        }

        // GET: Vagas
        public async Task<IActionResult> Index()
        {
            return View(await _context.vagas.ToListAsync());
        }

        public async Task<IActionResult> IndexAdmin()
        {
            return View(await _context.vagas.ToListAsync());
        }

        // GET: Vagas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaga = await _context.vagas
                .FirstOrDefaultAsync(m => m.Cod_vaga == id);
            if (vaga == null)
            {
                return NotFound();
            }

            return View(vaga);
        }

        // GET: Vagas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vagas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cod_vaga,Id_empresa,Cargo_vaga,Descricao_vaga,Salario_vaga,Vaga_pcd,Nivel_instrucao_vaga,Localidade_vaga,Regime_contratacao_vaga")] Vaga vaga)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vaga);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vaga);
        }

        // GET: Vagas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaga = await _context.vagas.FindAsync(id);
            if (vaga == null)
            {
                return NotFound();
            }
            return View(vaga);
        }

        // POST: Vagas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Cod_vaga,Id_empresa,Cargo_vaga,Descricao_vaga,Salario_vaga,Vaga_pcd,Nivel_instrucao_vaga,Localidade_vaga,Regime_contratacao_vaga")] Vaga vaga)
        {
            if (id != vaga.Cod_vaga)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vaga);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VagaExists(vaga.Cod_vaga))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexAdmin));
            }
            return View(vaga);
        }

        // GET: Vagas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaga = await _context.vagas
                .FirstOrDefaultAsync(m => m.Cod_vaga == id);
            if (vaga == null)
            {
                return NotFound();
            }

            return View(vaga);
        }

        // POST: Vagas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vaga = await _context.vagas.FindAsync(id);
            _context.vagas.Remove(vaga);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexAdmin));
        }

        private bool VagaExists(int id)
        {
            return _context.vagas.Any(e => e.Cod_vaga == id);
        }
    }
}
