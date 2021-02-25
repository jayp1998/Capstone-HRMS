using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_Project.Data.Models
{
    public partial class TblEmployee
    {
        public TblEmployee()
        {
            TblEducationDetails = new HashSet<TblEducationDetail>();
            TblJobDetailEmployees = new HashSet<TblJobDetail>();
            TblJobDetailReportsToNavigations = new HashSet<TblJobDetail>();
            TblLeaveApplicationsHistoryLeaveAppliedByNavigations = new HashSet<TblLeaveApplicationsHistory>();
            TblLeaveApplicationsHistoryLeaveAppliedToNavigations = new HashSet<TblLeaveApplicationsHistory>();
            TblLeaveApplicationsHistoryLeaveStatusUpdatedByNavigations = new HashSet<TblLeaveApplicationsHistory>();
            TblLeaveHoursOfferedEmployees = new HashSet<TblLeaveHoursOffered>();
            TblLeaveHoursOfferedUpdatedByNavigations = new HashSet<TblLeaveHoursOffered>();
            TblUsers = new HashSet<TblUser>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int GenderId { get; set; }
        public string Sin { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }

        public virtual TblGender Gender { get; set; }
        public virtual ICollection<TblEducationDetail> TblEducationDetails { get; set; }
        public virtual ICollection<TblJobDetail> TblJobDetailEmployees { get; set; }
        public virtual ICollection<TblJobDetail> TblJobDetailReportsToNavigations { get; set; }
        public virtual ICollection<TblLeaveApplicationsHistory> TblLeaveApplicationsHistoryLeaveAppliedByNavigations { get; set; }
        public virtual ICollection<TblLeaveApplicationsHistory> TblLeaveApplicationsHistoryLeaveAppliedToNavigations { get; set; }
        public virtual ICollection<TblLeaveApplicationsHistory> TblLeaveApplicationsHistoryLeaveStatusUpdatedByNavigations { get; set; }
        public virtual ICollection<TblLeaveHoursOffered> TblLeaveHoursOfferedEmployees { get; set; }
        public virtual ICollection<TblLeaveHoursOffered> TblLeaveHoursOfferedUpdatedByNavigations { get; set; }
        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
