using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Models
{
    public class Tokens
    {
        [Key]
        public int Id { get; set; }
        public string User_Id { get; set; }
        public string Token_Type { get; set; }
        public string JWT_Token { get; set; }
    }
}
