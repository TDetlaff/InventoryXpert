using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoryXpert.Data;
using InventoryXpert.Models;

namespace InventoryXpert.Controllers
{
    public class OrderRecordsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderRecordsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OrderRecords
        public async Task<IActionResult> Index()
        {
              return _context.OrderRecord != null ? 
                          View(await _context.OrderRecord.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.OrderRecord'  is null.");
        }

        // GET: OrderRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OrderRecord == null)
            {
                return NotFound();
            }

            var orderRecord = await _context.OrderRecord
                .FirstOrDefaultAsync(m => m.OrderRecordID == id);
            if (orderRecord == null)
            {
                return NotFound();
            }

            return View(orderRecord);
        }

        // GET: OrderRecords/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderRecordID,OrderID,ProductId,Quantity")] OrderRecord orderRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orderRecord);
        }

        // GET: OrderRecords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OrderRecord == null)
            {
                return NotFound();
            }

            var orderRecord = await _context.OrderRecord.FindAsync(id);
            if (orderRecord == null)
            {
                return NotFound();
            }
            return View(orderRecord);
        }

        // POST: OrderRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderRecordID,OrderID,ProductId,Quantity")] OrderRecord orderRecord)
        {
            if (id != orderRecord.OrderRecordID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderRecordExists(orderRecord.OrderRecordID))
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
            return View(orderRecord);
        }

        // GET: OrderRecords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OrderRecord == null)
            {
                return NotFound();
            }

            var orderRecord = await _context.OrderRecord
                .FirstOrDefaultAsync(m => m.OrderRecordID == id);
            if (orderRecord == null)
            {
                return NotFound();
            }

            return View(orderRecord);
        }

        // POST: OrderRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OrderRecord == null)
            {
                return Problem("Entity set 'ApplicationDbContext.OrderRecord'  is null.");
            }
            var orderRecord = await _context.OrderRecord.FindAsync(id);
            if (orderRecord != null)
            {
                _context.OrderRecord.Remove(orderRecord);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderRecordExists(int id)
        {
          return (_context.OrderRecord?.Any(e => e.OrderRecordID == id)).GetValueOrDefault();
        }
    }
}
