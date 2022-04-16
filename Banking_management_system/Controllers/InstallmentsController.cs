using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Banking_management_system.Data;
using Banking_management_system.Models;

namespace Banking_management_system.Controllers
{
    public class InstallmentsController : Controller
    {
        private readonly Banking_management_systemContext _context;

        public InstallmentsController(Banking_management_systemContext context)
        {
            _context = context;
        }

        // GET: Installments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Installment.ToListAsync());
        }

        // GET: Installments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var installment = await _context.Installment
                .FirstOrDefaultAsync(m => m.ID == id);
            if (installment == null)
            {
                return NotFound();
            }

            return View(installment);
        }

        // GET: Installments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Installments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Approved,OpenedTime,ClosedTime,TotalMonths,ClientID,ID,Money,MoneyPaid,MonthsPassed")] Installment installment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(installment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(installment);
        }

        // GET: Installments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var installment = await _context.Installment.FindAsync(id);
            if (installment == null)
            {
                return NotFound();
            }
            return View(installment);
        }

        // POST: Installments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Approved,OpenedTime,ClosedTime,TotalMonths,ClientID,ID,Money,MoneyPaid,MonthsPassed")] Installment installment)
        {
            if (id != installment.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(installment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstallmentExists(installment.ID))
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
            return View(installment);
        }

        // GET: Installments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var installment = await _context.Installment
                .FirstOrDefaultAsync(m => m.ID == id);
            if (installment == null)
            {
                return NotFound();
            }

            return View(installment);
        }

        // POST: Installments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var installment = await _context.Installment.FindAsync(id);
            _context.Installment.Remove(installment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstallmentExists(int id)
        {
            return _context.Installment.Any(e => e.ID == id);
        }
    }
}
