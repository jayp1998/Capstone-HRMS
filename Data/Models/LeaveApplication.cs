using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Models
{
    public class LeaveApplication
    {
        [Key]
        public int LeaveApplicationId { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public DateTime LeaveApplicationDate { get; set; }

        [ForeignKey("LeaveTypeId")]
        public int LeaveTypeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Reason { get; set; }
        public int? Hours { get; set; }

        [ForeignKey("EmployeeId")]
        public int LeaveAppliedTo { get; set; }

        [ForeignKey("LeaveStatusId")]
        public int LeaveStatusId { get; set; }
        public string Comment { get; set; }

        [ForeignKey("EmployeeId")]
        public int LeaveStatusUpdatedBy { get; set; }

        public DateTime LeaveStatusUpdatedAt { get; set; }
    }
}
