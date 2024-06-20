using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendMgmtSystm.Models;

namespace AttendMgmtSystm.Areas.Masters.Controllers
{
    public class AttendController : Controller
    {

        AttenMgmtSystmContext _context = new AttenMgmtSystmContext();

        public IActionResult Index()
        {
            var attendlist = _context.AttMsts.ToList();
            return View(attendlist);
        }
    }
}
