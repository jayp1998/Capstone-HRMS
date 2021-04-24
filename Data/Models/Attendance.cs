using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capstone_HRMS.Data.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }

        [Required]

        [ForeignKey("EmployeeId")]
         public int EmployeeId { get; set; }

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