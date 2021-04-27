using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS_Project.Data.Models
{
    public class EmployeeSalary
    {
        public long EmployeeSalaryId { get; set; }

        [Required]  
        [ForeignKey("EmployeeId")]
         public long EmployeeId { get; set; }

        [Required]  
        [DataType(DataType.Currency)]
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal NetSalary { get; set; }

        //Earnings

        [Required] 
        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal Basic { get; set; }


        [Required] 
        [DataType(DataType.Currency)]
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")] 
        public decimal DA { get; set; }

        [Required] 
        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal HRA { get; set; }

        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal Conveyance { get; set; }

        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal Allowance { get; set; }

        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal MedicalAllowance { get; set; }

        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal OthersEarnings { get; set; }

        //Deductions

        [Required] 
        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal TDS { get; set; }

        [Required] 
        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal ESI { get; set; }

        [Required] 
        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal PF { get; set; }

        [Required] 
        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal Leave { get; set; }

        [Required] 
        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal ProfTax { get; set; }

        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal LabourWelfare { get; set; }

        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal Fund { get; set; }

        [DataType(DataType.Currency)] 
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "You didn't enter a decimal!")]
        public decimal OthersDeductions { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Period { get; set; }


    }
}