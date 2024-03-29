using System.ComponentModel.DataAnnotations;

namespace HRMS_Project.Data.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}