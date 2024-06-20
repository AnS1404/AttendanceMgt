using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AttendMgmtSystm.Models;

namespace AttendMgmtSystm.Areas.Masters.Controllers
{
    [Area("Masters")]
    public class EmpMstsController : Controller
    {
        private readonly AttenMgmtSystmContext _context;

        public EmpMstsController(AttenMgmtSystmContext context)
        {
            _context = context;
        }

        // GET: Masters/EmpMsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmpMsts.ToListAsync());
        }

        // GET: Masters/EmpMsts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empMst = await _context.EmpMsts
                .FirstOrDefaultAsync(m => m.EmpId == id);
            if (empMst == null)
            {
                return NotFound();
            }

            return View(empMst);
        }

        // GET: Masters/EmpMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Masters/EmpMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpId,EmpName,Address,Status,CreatedBy,CreatedOn,UpdatedBy,UpdatedOn,PhNo,Email,Passw")] EmpMst empMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empMst);
        }

        // GET: Masters/EmpMsts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empMst = await _context.EmpMsts.FindAsync(id);
            if (empMst == null)
            {
                return NotFound();
            }
            return View(empMst);
        }

        // POST: Masters/EmpMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmpId,EmpName,Address,Status,CreatedBy,CreatedOn,UpdatedBy,UpdatedOn,PhNo,Email,Passw")] EmpMst empMst)
        {
            if (id != empMst.EmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpMstExists(empMst.EmpId))
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
            return View(empMst);
        }

        // GET: Masters/EmpMsts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empMst = await _context.EmpMsts
                .FirstOrDefaultAsync(m => m.EmpId == id);
            if (empMst == null)
            {
                return NotFound();
            }

            return View(empMst);
        }

        // POST: Masters/EmpMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empMst = await _context.EmpMsts.FindAsync(id);
            _context.EmpMsts.Remove(empMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpMstExists(int id)
        {
            return _context.EmpMsts.Any(e => e.EmpId == id);
        }
    }
}
