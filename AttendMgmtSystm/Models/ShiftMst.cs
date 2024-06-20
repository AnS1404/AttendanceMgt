using System;
using System.Collections.Generic;

#nullable disable

namespace AttendMgmtSystm.Models
{
    public partial class ShiftMst
    {
        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public bool? Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
