using Capstone_HRMS.Data.Services;
using HRMS_Project.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
         private readonly IEmployeeService _employeeService;

        public EmployeeController(ApplicationDbContext context, IEmployeeService employeeService)
        {
            _context = context;
            _employeeService = employeeService;
        }

        ///api/Employee/GetAllEmployee
        [HttpGet("[action]")]
        public IActionResult GetAllEmployee()
        {
            var result = from emp in _context.Set<Employee>()
                         from desg in _context.Set<Designation>().Where(desg => desg.DesignationId == emp.DesignationId).DefaultIfEmpty()
                         from dept in _context.Set<Department>().Where(dept => dept.DepartmentId == desg.DepartmentId).DefaultIfEmpty()
                         select new
                         {
                             emp.EmployeeId,
                             emp.FirstName,
                             emp.LastName,
                             emp.BirthDate,
                             emp.City,
                             emp.Country,
                             emp.Email,
                             emp.Facebook,
                             emp.Gender,
                             emp.LinkedIn,
                             emp.PhoneNumber,
                             emp.PostalCode,
                             emp.Province,
                             emp.Sin,
                             dept.DepartmentName,
                             desg.DesignationName
                         };
            return Ok(result);
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetEmployeebyId(int id)
        {
            var result = from emp in _context.Set<Employee>().Where(emp => emp.EmployeeId  == id)
                         from desg in _context.Set<Designation>().Where(desg => desg.DesignationId == emp.DesignationId).DefaultIfEmpty()
                         from dept in _context.Set<Department>().Where(dept => dept.DepartmentId == desg.DepartmentId).DefaultIfEmpty()
                         select new
                         {
                             emp.EmployeeId,
                             emp.FirstName,
                             emp.LastName,
                             emp.BirthDate,
                             emp.City,
                             emp.Country,
                             emp.Email,
                             emp.Facebook,
                             emp.Gender,
                             emp.LinkedIn,
                             emp.PhoneNumber,
                             emp.PostalCode,
                             emp.Province,
                             emp.Sin,
                             dept.DepartmentName,
                             desg.DesignationName
                         };
            return Ok(result);
        }

        //api/Employee/GetEmployeebySin/102
        [HttpGet("[action]/{sin}")]
        public IActionResult GetEmployeebySin(string sin)
        {
            var result = from emp in _context.Set<Employee>().Where(emp => emp.Sin == sin)
                         from desg in _context.Set<Designation>().Where(desg => desg.DesignationId == emp.DesignationId).DefaultIfEmpty()
                         from dept in _context.Set<Department>().Where(dept => dept.DepartmentId == desg.DepartmentId).DefaultIfEmpty()
                         select new
                         {
                             emp.EmployeeId,
                             emp.FirstName,
                             emp.LastName,
                             emp.BirthDate,
                             emp.City,
                             emp.Country,
                             emp.Email,
                             emp.Facebook,
                             emp.Gender,
                             emp.LinkedIn,
                             emp.PhoneNumber,
                             emp.PostalCode,
                             emp.Province,
                             emp.Sin,
                             dept.DepartmentName,
                             desg.DesignationName
                         };
            return Ok(result);
        }

        ///api/Employee/add
        [HttpPost("add")]
        public ActionResult<Employee> AddEmployee(Employee employee)
        {
            long temp = _employeeService.AddEmployee(employee);
            if (temp > 0)
            {
                return CreatedAtAction(nameof(employee), new { id = temp }, employee);
            }
            else
            {
                return UnprocessableEntity("Employee already exist");
            }
        }

        ///api/Employee/update
        [HttpPut("update")]
        public ActionResult<Employee> UpdateEmployee(Employee employee)
        {
            var e = _employeeService.UpdateEmployee(employee);
            if (e != null)
            {
                return e;
            }
            else
            {
                return UnprocessableEntity("Employee does not exist");
            }
        }

        ///api/Employee/delete/1
        [HttpDelete("delete/{id}")]
        public bool DeleteEmployee(int id)
        {
            return _employeeService.DeleteEmployee(id);
        }
    }
}
