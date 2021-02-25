using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_Project.Data.Models
{
    public partial class TblJobDetail
    {
        public int JobDetailsId { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeeStatusId { get; set; }
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
        public int ReportsTo { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? ProbationaryPeriodStartDate { get; set; }
        public DateTime? ProbationaryPeriodEndDate { get; set; }

        public virtual TblDepartment Department { get; set; }
        public virtual TblEmployee Employee { get; set; }
        public virtual TblEmploymentStatus EmployeeStatus { get; set; }
        public virtual TblPosition Position { get; set; }
        public virtual TblEmployee ReportsToNavigation { get; set; }
    }
}
