using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Car_Rental_System.Models;

namespace Car_Rental_System.Controllers
{
    public class DataModelsController : Controller
    {
        private readonly DataDbContext _context;

        public DataModelsController(DataDbContext context)
        {
            _context = context;
        }

        // GET: DataModels
        public async Task<IActionResult> Index()
        {
              return View(await _context.DataModels.ToListAsync());
        }

        // GET: DataModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DataModels == null)
            {
                return NotFound();
            }

            var dataModel = await _context.DataModels
                .FirstOrDefaultAsync(m => m.StdId == id);
            if (dataModel == null)
            {
                return NotFound();
            }

            return View(dataModel);
        }

        // GET: DataModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DataModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StdId,FirstName,LastName,FName,Age,E_Mail,Ctcno,CNIC,Address,gender,country")] DataModel dataModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dataModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dataModel);
        }

        // GET: DataModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DataModels == null)
            {
                return NotFound();
            }

            var dataModel = await _context.DataModels.FindAsync(id);
            if (dataModel == null)
            {
                return NotFound();
            }
            return View(dataModel);
        }

        // POST: DataModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StdId,FirstName,LastName,FName,Age,E_Mail,Ctcno,CNIC,Address,gender,country")] DataModel dataModel)
        {
            if (id != dataModel.StdId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dataModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataModelExists(dataModel.StdId))
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
            return View(dataModel);
        }

        // GET: DataModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DataModels == null)
            {
                return NotFound();
            }

            var dataModel = await _context.DataModels
                .FirstOrDefaultAsync(m => m.StdId == id);
            if (dataModel == null)
            {
                return NotFound();
            }

            return View(dataModel);
        }

        // POST: DataModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DataModels == null)
            {
                return Problem("Entity set 'DataDbContext.DataModels'  is null.");
            }
            var dataModel = await _context.DataModels.FindAsync(id);
            if (dataModel != null)
            {
                _context.DataModels.Remove(dataModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DataModelExists(int id)
        {
          return _context.DataModels.Any(e => e.StdId == id);
        }
    }
}
