using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoryXpert.Data;
using InventoryXpert.Models;
using Microsoft.AspNetCore.Authorization;

namespace InventoryXpert.Controllers
{
    [Authorize]
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
            var applicationDbContext = _context.OrderRecord.Include(o => o.Item).Include(o => o.Order);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: OrderRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OrderRecord == null)
            {
                return NotFound();
            }

            var orderRecord = await _context.OrderRecord
                .Include(o => o.Item)
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.OrderRecordId == id);
            if (orderRecord == null)
            {
                return NotFound();
            }

            return View(orderRecord);
        }

        // GET: OrderRecords/Create
        public IActionResult Create()
        {
            ViewData["ItemId"] = new SelectList(_context.Item, "ItemId", "ItemId");
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderId");
            return View();
        }

        // POST: OrderRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderRecordId,OrderId,ItemId,Quantity")] OrderRecord orderRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ItemId"] = new SelectList(_context.Item, "ItemId", "ItemId", orderRecord.ItemId);
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderId", orderRecord.OrderId);
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
            ViewData["ItemId"] = new SelectList(_context.Item, "ItemId", "ItemId", orderRecord.ItemId);
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderId", orderRecord.OrderId);
            return View(orderRecord);
        }

        // POST: OrderRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderRecordId,OrderId,ItemId,Quantity")] OrderRecord orderRecord)
        {
            if (id != orderRecord.OrderRecordId)
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
                    if (!OrderRecordExists(orderRecord.OrderRecordId))
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
            ViewData["ItemId"] = new SelectList(_context.Item, "ItemId", "ItemId", orderRecord.ItemId);
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderId", orderRecord.OrderId);
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
                .Include(o => o.Item)
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.OrderRecordId == id);
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
          return (_context.OrderRecord?.Any(e => e.OrderRecordId == id)).GetValueOrDefault();
        }
    }
}
