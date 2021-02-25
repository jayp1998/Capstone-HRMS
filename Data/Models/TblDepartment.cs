using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_Project.Data.Models
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblJobDetails = new HashSet<TblJobDetail>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public virtual TblPosition TblPosition { get; set; }
        public virtual ICollection<TblJobDetail> TblJobDetails { get; set; }
    }
}
