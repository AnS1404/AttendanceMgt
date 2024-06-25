using System;
using System.Collections.Generic;

#nullable disable

namespace AttendMgmtSystm.Models
{
    public partial class AttMst
    {
        public int EmpId { get; set; }
        public int? ShiftId { get; set; }
        public bool? Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public TimeSpan? CheckInTime { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckInDateTime { get; set; }
        public TimeSpan? CheckOutTime { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? CheckOutdateTime { get; set; }
        public int Id { get; set; }
    }
}
