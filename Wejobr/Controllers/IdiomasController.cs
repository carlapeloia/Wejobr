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
    public class IdiomasController : Controller
    {
        private readonly Context _context;

        public IdiomasController(Context context)
        {
            _context = context;
        }

        // GET: Idiomas
        public async Task<IActionResult> Index()
        {
            return View(await _context.idiomas.ToListAsync());
        }

        // GET: Idiomas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var idioma = await _context.idiomas
                .FirstOrDefaultAsync(m => m.Id_idioma == id);
            if (idioma == null)
            {
                return NotFound();
            }

            return View(idioma);
        }

        // GET: Idiomas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Idiomas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_idioma,Nome_idioma,Nivel_leitura_idioma,Nivel_escrita_idioma,Nivel_conversacao_idioma")] Idioma idioma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(idioma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(idioma);
        }

        // GET: Idiomas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var idioma = await _context.idiomas.FindAsync(id);
            if (idioma == null)
            {
                return NotFound();
            }
            return View(idioma);
        }

        // POST: Idiomas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_idioma,Nome_idioma,Nivel_leitura_idioma,Nivel_escrita_idioma,Nivel_conversacao_idioma")] Idioma idioma)
        {
            if (id != idioma.Id_idioma)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(idioma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IdiomaExists(idioma.Id_idioma))
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
            return View(idioma);
        }

        // GET: Idiomas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var idioma = await _context.idiomas
                .FirstOrDefaultAsync(m => m.Id_idioma == id);
            if (idioma == null)
            {
                return NotFound();
            }

            return View(idioma);
        }

        // POST: Idiomas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var idioma = await _context.idiomas.FindAsync(id);
            _context.idiomas.Remove(idioma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IdiomaExists(int id)
        {
            return _context.idiomas.Any(e => e.Id_idioma == id);
        }
    }
}
