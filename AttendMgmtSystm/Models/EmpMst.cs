using System;
using System.Collections.Generic;

#nullable disable

namespace AttendMgmtSystm.Models
{
    public partial class EmpMst
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public bool? Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? PhNo { get; set; }
        public string Email { get; set; }
        public string Passw { get; set; }
    }
}
