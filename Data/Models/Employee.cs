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
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }

        [ForeignKey("DesignationId")]
        public int DesignationId { get; set; }
        public string Sin { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }

        [ForeignKey("Id")]
        public int UserId { get; set; }

        public virtual ICollection<EducationDetail> EducationDetail { get; set; }
        public virtual ICollection<JobDetail> JobDetail { get; set; }
        public virtual ICollection<LeaveApplication> LeaveApplication { get; set; }
        public virtual ICollection<Attendance> Attendance { get; set; }
        
    }
}
