using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entities;
using Data.Migrations;
using Laboratorium3.Models;

namespace Laboratorium3_Product.Controllers;

public class ProducentController : Controller
{
    private readonly AppDbContext _context;

        public ProducentController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Producent
        public async Task<IActionResult> Index()
        {
            return _context.Producent != null ?
                        View(await _context.Producent.ToListAsync()) :
                        Problem("Entity set 'AppDbContext.Producent'  is null.");
        }

        // GET: Producent/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Producent == null)
            {
                return NotFound();
            }

            var ProducentEntity = await _context.Producent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ProducentEntity == null)
            {
                return NotFound();
            }

            return View(ProducentEntity);
        }

        // GET: Producent/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Producent/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Producent producent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producent);
        }

        // GET: Producent/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Producent == null)
            {
                return NotFound();
            }

            var producentEntity = await _context.Producent.FindAsync(id);
            if (producentEntity == null)
            {
                return NotFound();
            }
            return View(producentEntity);
        }

        // POST: Producent/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] ProducentEntity producentEntity)
        {
            if (id != producentEntity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producentEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProducentEntityExists(producentEntity.Id))
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
            return View(producentEntity);
        }

        // GET: Producent/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Producent == null)
            {
                return NotFound();
            }

            var producentEntity = await _context.Producent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producentEntity == null)
            {
                return NotFound();
            }

            return View(producentEntity);
        }

        // POST: Producent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Producent == null)
            {
                return Problem("Entity set 'AppDbContext.Producent'  is null.");
            }
            var producentEntity = await _context.Producent.FindAsync(id);
            if (producentEntity != null)
            {
                _context.Producent.Remove(producentEntity);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProducentEntityExists(int id)
        {
            return (_context.Producent?.Any(e => e.Id == id)).GetValueOrDefault();
        }
}