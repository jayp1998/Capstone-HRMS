using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Models
{
    public class Designation
    {
        [Key]
        public int DesignationId { get; set; }
        public string DesignationName { get; set; }

        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
