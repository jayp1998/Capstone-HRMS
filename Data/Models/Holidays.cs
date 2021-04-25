using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Models
{
    public class Holidays
    {
        [Key]
        [Required]
        public int HolidaysId { get; set; }

         [Required]
         [StringLength(100)]
        public string Title { get; set; }

         [Required]
         [StringLength(100)]
        public string Day { get; set; }

         [Required]
         [DataType(DataType.Date)]
        public DateTime HolidayDate { get; set; }
    }
}
