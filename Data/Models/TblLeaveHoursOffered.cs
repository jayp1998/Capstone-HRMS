using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_Project.Data.Models
{
    public partial class TblLeaveHoursOffered
    {
        public int LeaveHoursOfferedId { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public int? Hours { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual TblEmployee Employee { get; set; }
        public virtual TblLeaveType LeaveType { get; set; }
        public virtual TblEmployee UpdatedByNavigation { get; set; }
    }
}
