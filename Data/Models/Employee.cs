using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Capstone_HRMS.Data.Models;

namespace HRMS_Project.Data.Models
{
    public class Employee
    {
        [Key]
        public long EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]

        [ForeignKey("DesignationId")]
        public int DesignationId { get; set; }

        [Required]
         [StringLength(100)]
        public string Sin { get; set; }

        [StringLength(1000)]
        public string StreetAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        
        [Required]
        [StringLength(100)]
        public string Province { get; set; }

        [Required]
        [StringLength(100)]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(100)]
        public string Country { get; set; }

        [Required]
        [StringLength(100)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        
        [StringLength(100)]
        public string LinkedIn { get; set; }

        [StringLength(100)]
        public string Twitter { get; set; }

        [StringLength(100)]
        public string Facebook { get; set; }

        [ForeignKey("Id")]
        public long UserId { get; set; }

        public virtual ICollection<EducationDetail> EducationDetail { get; set; }
        public virtual ICollection<JobProfileDetail> JobProfileDetail { get; set; }
        public virtual ICollection<LeaveApplication> LeaveApplication { get; set; }
        public virtual ICollection<Attendance> Attendance { get; set; }
        
    }
}
