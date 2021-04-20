using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Models
{
    public class EducationDetail
    {
        [Key]
        public int EducationDetailsId { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public string UniversityName { get; set; }
        public string DegreeName { get; set; }
        public string Specialization { get; set; }
        public string Gpa { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
