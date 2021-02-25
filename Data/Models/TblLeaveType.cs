using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_Project.Data.Models
{
    public partial class TblLeaveType
    {
        public TblLeaveType()
        {
            TblLeaveApplicationsHistories = new HashSet<TblLeaveApplicationsHistory>();
            TblLeaveHoursOffereds = new HashSet<TblLeaveHoursOffered>();
        }

        public int LeaveTypeId { get; set; }
        public string TypeName { get; set; }
        public int? NumberOfHours { get; set; }

        public virtual ICollection<TblLeaveApplicationsHistory> TblLeaveApplicationsHistories { get; set; }
        public virtual ICollection<TblLeaveHoursOffered> TblLeaveHoursOffereds { get; set; }
    }
}
