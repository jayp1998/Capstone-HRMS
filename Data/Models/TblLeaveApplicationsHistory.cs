using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_Project.Data.Models
{
    public partial class TblLeaveApplicationsHistory
    {
        public int LeaveApplicationId { get; set; }
        public int LeaveAppliedBy { get; set; }
        public DateTime LeaveAppliedOn { get; set; }
        public int LeaveType { get; set; }
        public DateTime LeaveFrom { get; set; }
        public DateTime LeaveTo { get; set; }
        public string Reason { get; set; }
        public int? Hours { get; set; }
        public int LeaveAppliedTo { get; set; }
        public bool? Status { get; set; }
        public string Comment { get; set; }
        public int LeaveStatusUpdatedBy { get; set; }
        public DateTime LeaveStatusUpdatedAt { get; set; }

        public virtual TblEmployee LeaveAppliedByNavigation { get; set; }
        public virtual TblEmployee LeaveAppliedToNavigation { get; set; }
        public virtual TblEmployee LeaveStatusUpdatedByNavigation { get; set; }
        public virtual TblLeaveType LeaveTypeNavigation { get; set; }
    }
}
