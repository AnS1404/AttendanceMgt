using System.Collections.Generic;

namespace AttendMgmtSystm.Models
{
    public class HomeViewModel
    {
        public int EmployeeCount { get; set; }
        public List<EmpMst> RecentEmployees { get; set; }
    }
}