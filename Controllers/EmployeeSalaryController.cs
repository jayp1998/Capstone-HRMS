using Capstone_HRMS.Data.Services;
using HRMS_Project.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_HRMS.Controllers
{
     [Route("api/[controller]")]
     [ApiController]
     public class EmployeeSalaryController: ControllerBase
    {
        private readonly ApplicationDbContext _context;
         private readonly IEmployeeSalaryService _EmployeeSalaryService;

        public EmployeeSalaryController(ApplicationDbContext context, IEmployeeSalaryService EmployeeSalaryService)
        {
            _context = context;
            _EmployeeSalaryService = EmployeeSalaryService;
        }
        
        //api/EmployeeSalary/GetAllEmployeeSalary
        [HttpGet("[action]")]
       public IActionResult GetAllEmployeeSalary()
        {
            
        var result  = from  salary in _context.Set<EmployeeSalary>()
             from emp in _context.Set<Employee>().Where(emp => emp.EmployeeId == salary.EmployeeId).DefaultIfEmpty()
             select new {
                  salary.EmployeeSalaryId,
                        employeeFullName = emp.FirstName + " " + emp.LastName,
                        emp.EmployeeId,
                        salary.NetSalary, 
                        salary.Basic, 
                        salary.DA, 
                        salary.HRA, 
                        salary.Conveyance ,
                        salary.Allowance ,
                        salary.MedicalAllowance ,
                        salary.OthersEarnings,
                         salary.TDS,
                         salary.ESI,
                         salary.PF,
                         salary.Leave,
                         salary.ProfTax,
                         salary.LabourWelfare,
                         salary.Fund,
                         salary.OthersDeductions,
                         salary.Period,
                         };
            return Ok(result.OrderBy(e => e.Period).OrderBy(e => e.employeeFullName));
        }
        
        //api/EmployeeSalary/GetAllEmployeeSalaryByEmployeeId/1
        [HttpGet("[action]/{id}")]
       public IActionResult GetAllEmployeeSalaryByEmployeeId(long id)
        {
            
           var result  = from  salary in _context.Set<EmployeeSalary>().Where(emp => emp.EmployeeId == id)
             from emp in _context.Set<Employee>().Where(emp => emp.EmployeeId == salary.EmployeeId).DefaultIfEmpty()
             select new {
                  salary.EmployeeSalaryId,
                        employeeFullName = emp.FirstName + " " + emp.LastName,
                        emp.EmployeeId,
                        salary.NetSalary, 
                        salary.Basic, 
                        salary.DA, 
                        salary.HRA, 
                        salary.Conveyance ,
                        salary.Allowance ,
                        salary.MedicalAllowance ,
                        salary.OthersEarnings,
                         salary.TDS,
                         salary.ESI,
                         salary.PF,
                         salary.Leave,
                         salary.ProfTax,
                         salary.LabourWelfare,
                         salary.Fund,
                         salary.OthersDeductions,
                         salary.Period,
                         };
            return Ok(result.OrderBy(e => e.Period).OrderBy(e => e.employeeFullName));
       
        }
        
         //api/EmployeeSalary/GetEmployeeSalaryByPeriod/2021-01 
        [HttpGet("[action]/{period}")]
       public IActionResult GetEmployeeSalaryByPeriod(DateTime period)
        {
            
             var result  = from  salary in _context.Set<EmployeeSalary>()
             from emp in _context.Set<Employee>().Where(emp => emp.EmployeeId == salary.EmployeeId).DefaultIfEmpty()
             select new {
                  salary.EmployeeSalaryId,
                        employeeFullName = emp.FirstName + " " + emp.LastName,
                        emp.EmployeeId,
                        salary.NetSalary, 
                        salary.Basic, 
                        salary.DA, 
                        salary.HRA, 
                        salary.Conveyance ,
                        salary.Allowance ,
                        salary.MedicalAllowance ,
                        salary.OthersEarnings,
                         salary.TDS,
                         salary.ESI,
                         salary.PF,
                         salary.Leave,
                         salary.ProfTax,
                         salary.LabourWelfare,
                         salary.Fund,
                         salary.OthersDeductions,
                         salary.Period,
                         };
            return Ok(result.Where(salary => salary.Period.Month == period.Month && salary.Period.Year == period.Year));
        }

        //api/EmployeeSalary/add
        [HttpPost("add")]
        public ActionResult<EmployeeSalary> AddEmployeeSalary(EmployeeSalary salary)
        {
            long temp = _EmployeeSalaryService.AddEmployeeSalary(salary);
            if (temp > 0)
            {
                return CreatedAtAction(nameof(salary), new { id = temp }, salary);
            }
            else
            {
                return UnprocessableEntity("Employee Salary already exist");
            }
        }

        ///api/EmployeeSalary/update
        [HttpPut("update")]
        public ActionResult<EmployeeSalary> UpdateEmployeeSalary(EmployeeSalary salary)
        {
            var e = _EmployeeSalaryService.UpdateEmployeeSalary(salary);
            if (e != null)
            {
                return e;
            }
            else
            {
                return UnprocessableEntity("Employee Salary does not exist or alrady exist same data");
            }
        }

        ///api/EmployeeSalary/delete/1
        [HttpDelete("delete/{id}")]
        public bool DeleteEmployee(int id)
        {
            return _EmployeeSalaryService.DeleteEmployeeSalary(id);
        }
    }
}