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
        public int HolidaysId { get; set; }
        public string Title { get; set; }
        public string Day { get; set; }
        public DateTime HolidayDate { get; set; }
    }
}
