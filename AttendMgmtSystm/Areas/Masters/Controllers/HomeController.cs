using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendMgmtSystm.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace AttendMgmtSystm.Areas.Masters.Controllers
{
    [Area("Masters")]
    public class HomeController : Controller
    {
        private readonly AttenMgmtSystmContext _context;

        public HomeController(AttenMgmtSystmContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("EmployeeId") != null)
            {
                var EmpId = Convert.ToInt32(HttpContext.Session.GetString("EmployeeId").ToString());
                AttMst atmstr = new AttMst();
                DateTime date = DateTime.Parse(DateTime.Now.ToString("dd-MMM-yyyy"));
                var isexist1 = _context.AttMsts.Where(a => a.EmpId == EmpId && a.CheckOutDate == date).Any();
                ViewBag.Exist1 = isexist1;
                var isexist = _context.AttMsts.Where(a => a.EmpId == EmpId && a.CheckInDate == date).Any();
                ViewBag.Exist = isexist;
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckIn()
        {
            AttMst atm = new AttMst();
            atm.CheckInDate = DateTime.Now.Date;
            string time = DateTime.Now.ToString("HH:mm:ss");
            atm.CheckInTime = DateTime.Now.TimeOfDay;
            atm.CheckInDateTime = DateTime.Now;
            if (HttpContext.Session.GetString("EmployeeId") != null)
            {
                atm.EmpId = Convert.ToInt32(HttpContext.Session.GetString("EmployeeId").ToString());
                atm.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("EmployeeId").ToString());

                atm.ShiftId = 1;
                _context.Add(atm);
                _context.SaveChanges();

                var isexist = _context.AttMsts.Where(a => a.EmpId == atm.EmpId && a.CheckInDate == atm.CheckInDate).Any();
                ViewBag.Exist = isexist;
                ViewBag.Exist1 = false;
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult CheckOut()
        {
            AttMst atmstr = new AttMst();
            if (HttpContext.Session.GetString("EmployeeId") != null)
            {
                var EmpId = Convert.ToInt32(HttpContext.Session.GetString("EmployeeId").ToString());
                atmstr = _context.AttMsts.Where(a => a.EmpId == EmpId).FirstOrDefault();
                atmstr.EmpId = EmpId;
                atmstr.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("EmployeeId").ToString());
                atmstr.CheckOutDate = DateTime.Now.Date;
                string time = DateTime.Now.ToString("HH:mm:ss");
                atmstr.CheckOutTime = DateTime.Now.TimeOfDay;
                atmstr.CheckOutdateTime = DateTime.Now;
                atmstr.ShiftId = 1;
                _context.Update(atmstr);
                _context.SaveChanges();

                var isexist = _context.AttMsts.Where(a => a.EmpId == atmstr.EmpId && a.CheckOutDate == atmstr.CheckOutDate).Any();
                ViewBag.Exist1 = isexist;
                ViewBag.Exist = false;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Exist = false;
                ViewBag.Exist1 = false;
                
            }
            return RedirectToAction("Index");
        }
    }
}
