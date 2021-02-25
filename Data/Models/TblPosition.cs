using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_Project.Data.Models
{
    public partial class TblPosition
    {
        public TblPosition()
        {
            TblJobDetails = new HashSet<TblJobDetail>();
        }

        public int PositionId { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }

        public virtual TblDepartment Position { get; set; }
        public virtual ICollection<TblJobDetail> TblJobDetails { get; set; }
    }
}
