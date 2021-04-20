using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Models
{
    public class LeaveStatus
    {
        [Key]
        public int LeaveStatusId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<LeaveApplication> LeaveApplication { get; set; }
    }
}
