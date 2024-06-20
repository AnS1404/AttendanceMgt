using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendMgmtSystm.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendMgmtSystm.Areas.Masters.Controllers
{
    [Area ("Masters")]
    public class ShiftController : Controller
    {
        private readonly AttenMgmtSystmContext _context;
        public ShiftController(AttenMgmtSystmContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShiftMsts.ToListAsync());
        }
        
        //GET: Masters/EmpMsts/Details//5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var shfMst = await _context.ShiftMsts
                .FirstOrDefaultAsync(m => m.ShiftId == id);
            if (shfMst == null)
            {
                return NotFound();
            }
            return View(shfMst);
        }

        //GET: Masters/ShiftMsts
        public IActionResult Create()
        {
            return View();
        }
        // POST: Masters/EmpMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShiftId,ShiftName,CreatedBy,CreatedOn,UpdatedBy,UpdatedOn")] ShiftMst shfMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shfMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shfMst);
        }

        //GET: Masters/ShiftMsts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var shfMst = await _context.ShiftMsts.FindAsync(id);
            if(shfMst == null)
            {
                return NotFound();
            }
            return View(shfMst);
        }
        // POST: Masters/EmpMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShiftId,ShiftName,CreatedBy,CreatedOn,UpdatedBy,UpdatedOn")] ShiftMst shfMst)
        {
            if (id != shfMst.ShiftId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shfMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShiftMstExists(shfMst.ShiftId))
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
            return View(shfMst);
        }
        // GET: Masters/ShiftMsts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shfMst = await _context.ShiftMsts
                .FirstOrDefaultAsync(m => m.ShiftId == id);
            if (shfMst == null)
            {
                return NotFound();
            }

            return View(shfMst);
        }

        // POST: Masters/ShiftMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shfMst = await _context.ShiftMsts.FindAsync(id);
            _context.ShiftMsts.Remove(shfMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShiftMstExists(int id)
        {
            return _context.ShiftMsts.Any(e => e.ShiftId == id);
        }
        
    }
}
