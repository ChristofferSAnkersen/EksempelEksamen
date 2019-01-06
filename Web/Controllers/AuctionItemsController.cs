using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using API.Entities.DataContext;
using API.Entities.Models;

namespace Web.Controllers
{
    public class AuctionItemsController : Controller
    {
        private readonly AuctionContext _context;

        public AuctionItemsController(AuctionContext context)
        {
            _context = context;
        }

        // GET: AuctionItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.AuctionItems.ToListAsync());
        }

        // GET: AuctionItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auctionItem = await _context.AuctionItems
                .FirstOrDefaultAsync(m => m.ItemNumber == id);
            if (auctionItem == null)
            {
                return NotFound();
            }

            return View(auctionItem);
        }

        // GET: AuctionItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AuctionItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemNumber,ItemDescription,RatingPrice,BidPrice,BidCustomName,BidCustomPhone,BidTimestamp")] AuctionItem auctionItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(auctionItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(auctionItem);
        }

        // GET: AuctionItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auctionItem = await _context.AuctionItems.FindAsync(id);
            if (auctionItem == null)
            {
                return NotFound();
            }
            return View(auctionItem);
        }

        // POST: AuctionItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemNumber,ItemDescription,RatingPrice,BidPrice,BidCustomName,BidCustomPhone,BidTimestamp")] AuctionItem auctionItem)
        {
            if (id != auctionItem.ItemNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(auctionItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuctionItemExists(auctionItem.ItemNumber))
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
            return View(auctionItem);
        }

        // GET: AuctionItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auctionItem = await _context.AuctionItems
                .FirstOrDefaultAsync(m => m.ItemNumber == id);
            if (auctionItem == null)
            {
                return NotFound();
            }

            return View(auctionItem);
        }

        // POST: AuctionItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var auctionItem = await _context.AuctionItems.FindAsync(id);
            _context.AuctionItems.Remove(auctionItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuctionItemExists(int id)
        {
            return _context.AuctionItems.Any(e => e.ItemNumber == id);
        }
    }
}
