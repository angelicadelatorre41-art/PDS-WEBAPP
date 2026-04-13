using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PDS_WebApp.Models;

namespace PDS_WebApp.Controllers
{
    public class PDSController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PDSController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PDS - Display all records
        public async Task<IActionResult> Index()
        {
            var records = await _context.PersonalDataSheets.ToListAsync();
            return View(records);
        }

        // GET: PDS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var pds = await _context.PersonalDataSheets.FirstOrDefaultAsync(m => m.Id == id);
            if (pds == null) return NotFound();

            return View(pds);
        }

        // GET: PDS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PDS/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonalDataSheet pds)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pds);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Record created successfully!";
                return RedirectToAction(nameof(Index));
            }
            return View(pds);
        }

        // GET: PDS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var pds = await _context.PersonalDataSheets.FindAsync(id);
            if (pds == null) return NotFound();

            return View(pds);
        }

        // POST: PDS/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PersonalDataSheet pds)
        {
            if (id != pds.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pds);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Record updated successfully!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.PersonalDataSheets.Any(e => e.Id == pds.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pds);
        }

        // GET: PDS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var pds = await _context.PersonalDataSheets.FirstOrDefaultAsync(m => m.Id == id);
            if (pds == null) return NotFound();

            return View(pds);
        }

        // POST: PDS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pds = await _context.PersonalDataSheets.FindAsync(id);
            if (pds != null)
            {
                _context.PersonalDataSheets.Remove(pds);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Record deleted successfully!";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
