using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capstone_HRMS.Data.Models
{
    public class Attendance
    {
        [Key]
        public long AttendanceId { get; set; }

        [Required]

        [ForeignKey("EmployeeId")]
         public long EmployeeId { get; set; }

         [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime PunchIn { get; set; }

        [Required]
        public DateTime PunchOut { get; set; }

        [Required]
        public Boolean PresentAbsent { get; set; } 

    }
}