using HRMS_Project.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Controllers
{
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEmployee()
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
    }
}
