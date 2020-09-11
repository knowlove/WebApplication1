using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using D6TWO_Model;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class OrderTablesController : Controller
    {
        private readonly WebApplication1Context _context;

        public OrderTablesController(WebApplication1Context context)
        {
            _context = context;
        }

        // GET: OrderTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrderTable.ToListAsync());
        }

        // GET: OrderTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderTable = await _context.OrderTable
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (orderTable == null)
            {
                return NotFound();
            }

            return View(orderTable);
        }

        // GET: OrderTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,ShaoppingName,MoneyType,MoneyState,UserName,OrderPhone,OrderAddress,OrderState,DistributionDealer,Engine,CarColor,OrderTime,MoneyTime,MoneyBank,PayType,PayMoney,LatelyTime,OrderTransfer")] OrderTable orderTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orderTable);
        }

        // GET: OrderTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderTable = await _context.OrderTable.FindAsync(id);
            if (orderTable == null)
            {
                return NotFound();
            }
            return View(orderTable);
        }

        // POST: OrderTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,ShaoppingName,MoneyType,MoneyState,UserName,OrderPhone,OrderAddress,OrderState,DistributionDealer,Engine,CarColor,OrderTime,MoneyTime,MoneyBank,PayType,PayMoney,LatelyTime,OrderTransfer")] OrderTable orderTable)
        {
            if (id != orderTable.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderTableExists(orderTable.OrderId))
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
            return View(orderTable);
        }

        // GET: OrderTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderTable = await _context.OrderTable
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (orderTable == null)
            {
                return NotFound();
            }

            return View(orderTable);
        }

        // POST: OrderTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderTable = await _context.OrderTable.FindAsync(id);
            _context.OrderTable.Remove(orderTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderTableExists(int id)
        {
            return _context.OrderTable.Any(e => e.OrderId == id);
        }
    }
}
