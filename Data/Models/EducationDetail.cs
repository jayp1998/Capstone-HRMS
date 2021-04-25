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
        public int EducationDetailId { get; set; }

         [Required]  
        [ForeignKey("EmployeeId")]
        public long EmployeeId { get; set; }

         [Required] 
         [StringLength(100)] 
        public string UniversityName { get; set; }

         [Required]  
         [StringLength(200)]
        public string DegreeName { get; set; }

         [Required] 
         [StringLength(200)] 
        public string Specialization { get; set; }

         [Required]  
         [StringLength(100)]
        public string Gpa { get; set; }

        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
    }
}
