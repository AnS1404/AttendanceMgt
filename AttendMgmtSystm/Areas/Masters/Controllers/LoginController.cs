using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendMgmtSystm.Models;
using Microsoft.AspNetCore.Http;

namespace AttendMgmtSystm.Areas.Masters.Controllers
{
    [Area("Masters")]
    public class LoginController : Controller
    {
        private readonly AttenMgmtSystmContext _context;
        public LoginController(AttenMgmtSystmContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(EmpMst emp)
        {
            var user = _context.EmpMsts.FirstOrDefault(a => a.PhNo == emp.PhNo && a.Passw == emp.Passw);
            if (user != null)
            {
                HttpContext.Session.SetString("EmployeePhone", user.PhNo?.ToString());
                HttpContext.Session.SetString("EmployeeId", user.EmpId.ToString());
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Invalid username or password");
            return View(emp);
        }
    }
}
