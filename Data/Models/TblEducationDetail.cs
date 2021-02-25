using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_Project.Data.Models
{
    public partial class TblEducationDetail
    {
        public int EducationDetailsId { get; set; }
        public int EmployeeId { get; set; }
        public string UniversityName { get; set; }
        public string DegreeName { get; set; }
        public string Specialization { get; set; }
        public string Gpa { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual TblEmployee Employee { get; set; }
    }
}
