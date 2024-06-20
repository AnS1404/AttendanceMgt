using System;
using System.Collections.Generic;

#nullable disable

namespace AttendMgmtSystm.Models
{
    public partial class AttMst
    {
        public int EmpId { get; set; }
        public int? ShiftId { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public bool? Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
