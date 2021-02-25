using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_Project.Data.Models
{
    public partial class TblGender
    {
        public TblGender()
        {
            TblEmployees = new HashSet<TblEmployee>();
        }

        public int GenderId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TblEmployee> TblEmployees { get; set; }
    }
}
