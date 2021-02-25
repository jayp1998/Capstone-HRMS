using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_Project.Data.Models
{
    public partial class TblEmploymentStatus
    {
        public TblEmploymentStatus()
        {
            TblJobDetails = new HashSet<TblJobDetail>();
        }

        public int EmploymentStatusId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<TblJobDetail> TblJobDetails { get; set; }
    }
}
