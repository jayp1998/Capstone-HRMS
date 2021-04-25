using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Models
{
    public class JobProfileDetail
    {
        [Required]
        [Key]
        public int JobProfileDetailId { get; set; }

        [Required]
        [ForeignKey("EmployeeId")]
        public long EmployeeId { get; set; }
        
        [Required]
         [ForeignKey("EmployeeId")]
        public long ReportsTo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? ProbationaryPeriodStartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? ProbationaryPeriodEndDate { get; set; }
    }
}
