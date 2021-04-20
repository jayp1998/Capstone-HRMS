using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Models
{
    public class JobDetail
    {
        [Key]
        public int JobDetailsId { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public int ReportsTo { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? ProbationaryPeriodStartDate { get; set; }
        public DateTime? ProbationaryPeriodEndDate { get; set; }
    }
}
