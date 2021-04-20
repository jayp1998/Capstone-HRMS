using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Models
{
    public class LeaveType
    {
        [Key]
        public int LeaveTypeId { get; set; }
        public string TypeName { get; set; }
        public int? NumberOfHours { get; set; }

        public virtual ICollection<LeaveApplication> LeaveApplication { get; set; }
    }
}
