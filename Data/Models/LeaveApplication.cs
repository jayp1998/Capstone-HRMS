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
        public long LeaveApplicationId { get; set; }

        [Required]
        [ForeignKey("EmployeeId")]
        public long EmployeeId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime LeaveApplicationDate { get; set; }

        [Required]
        [ForeignKey("LeaveTypeId")]
        public int LeaveTypeId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FromDate { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime ToDate { get; set; }

        [Required]
        [StringLength(100)]   
        public string Reason { get; set; }

        public int? Hours { get; set; }

        [Required]
        [ForeignKey("EmployeeId")]
        public long LeaveAppliedTo { get; set; }

        [Required]
        [ForeignKey("LeaveStatusId")]
        public int LeaveStatusId { get; set; }


        [StringLength(1000)]
        public string Comment { get; set; }

        [ForeignKey("EmployeeId")]
        public long LeaveStatusUpdatedBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime LeaveStatusUpdatedAt { get; set; }
    }
}
