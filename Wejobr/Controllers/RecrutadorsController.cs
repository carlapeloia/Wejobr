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
    public class RecrutadorsController : Controller
    {
        private readonly Context _context;

        public RecrutadorsController(Context context)
        {
            _context = context;
        }

        // GET: Recrutadors
        public async Task<IActionResult> Index()
        {
            return View(await _context.recrutadores.ToListAsync());
        }

        // GET: Recrutadors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recrutador = await _context.recrutadores
                .FirstOrDefaultAsync(m => m.Id_recrutador == id);
            if (recrutador == null)
            {
                return NotFound();
            }

            return View(recrutador);
        }

        // GET: Recrutadors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recrutadors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_recrutador,Nome_empresa,Id_empresa,Nome_recrutador,Cargo_recrutador,Departamento_recrutador,Email_recrutador,Tel_recrutador,Contato2_recrutador,Senha_recrutador")] Recrutador recrutador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recrutador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recrutador);
        }

        // GET: Recrutadors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recrutador = await _context.recrutadores.FindAsync(id);
            if (recrutador == null)
            {
                return NotFound();
            }
            return View(recrutador);
        }

        // POST: Recrutadors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_recrutador,Nome_empresa,Id_empresa,Nome_recrutador,Cargo_recrutador,Departamento_recrutador,Email_recrutador,Tel_recrutador,Contato2_recrutador,Senha_recrutador")] Recrutador recrutador)
        {
            if (id != recrutador.Id_recrutador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recrutador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecrutadorExists(recrutador.Id_recrutador))
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
            return View(recrutador);
        }

        // GET: Recrutadors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recrutador = await _context.recrutadores
                .FirstOrDefaultAsync(m => m.Id_recrutador == id);
            if (recrutador == null)
            {
                return NotFound();
            }

            return View(recrutador);
        }

        // POST: Recrutadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recrutador = await _context.recrutadores.FindAsync(id);
            _context.recrutadores.Remove(recrutador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecrutadorExists(int id)
        {
            return _context.recrutadores.Any(e => e.Id_recrutador == id);
        }
    }
}
