using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FutarSeged.Data;
using FutarSeged.Models;

namespace FutarSeged.Controllers
{
    public class AddressModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AddressModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AddressModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Address.ToListAsync());
        }

        // GET: AddressModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressModel = await _context.Address
                .FirstOrDefaultAsync(m => m.AddressId == id);
            if (addressModel == null)
            {
                return NotFound();
            }

            return View(addressModel);
        }

        // GET: AddressModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AddressModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AddressId,AddressPostCode,AddressCity,AddressStreetName,AddressHouseNumber,AddressDescription")] AddressModel addressModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addressModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addressModel);
        }

        // GET: AddressModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressModel = await _context.Address.FindAsync(id);
            if (addressModel == null)
            {
                return NotFound();
            }
            return View(addressModel);
        }

        // POST: AddressModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AddressId,AddressPostCode,AddressCity,AddressStreetName,AddressHouseNumber,AddressDescription")] AddressModel addressModel)
        {
            if (id != addressModel.AddressId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addressModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddressModelExists(addressModel.AddressId))
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
            return View(addressModel);
        }

        // GET: AddressModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressModel = await _context.Address
                .FirstOrDefaultAsync(m => m.AddressId == id);
            if (addressModel == null)
            {
                return NotFound();
            }

            return View(addressModel);
        }

        // POST: AddressModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addressModel = await _context.Address.FindAsync(id);
            _context.Address.Remove(addressModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddressModelExists(int id)
        {
            return _context.Address.Any(e => e.AddressId == id);
        }
    }
}
