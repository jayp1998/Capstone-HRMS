using HRMS_Project.Data.Models;
using HRMS_Project.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IDepartmentService _departmentService;

        public DepartmentController(ApplicationDbContext context, IDepartmentService departmentService)
        {
            _context = context;
            _departmentService = departmentService;
        }

        [HttpGet("[action]")]
        public ActionResult<IEnumerable<Department>> GetAllDepartments()
        {
            return _departmentService.GetAllDepartments();
        }

        [HttpGet("[action]/{id}")]
        public ActionResult<Department> GetDepartmentById(int id)
        {
            return _departmentService.GetDepartmentById(id);
        }

         [HttpGet("[action]/{departmentName}")]
        public ActionResult<Department> GetDepartmentByTitle(string departmentName)
        {
            return _departmentService.GetDepartmentByName(departmentName);
        }

        [HttpPost("add")]
        public ActionResult<Department> AddDepartment(Department Department)
        {
            int temp = _departmentService.AddDepartment(Department.DepartmentName);
            if (temp > 0)
            {
                return CreatedAtAction(nameof(Department), new { id = temp }, Department);
            }
            else
            {
                return UnprocessableEntity("Department already exist");
            }
        }

        [HttpPut("update")]
        public ActionResult<Department> UpdateDepartment(Department Department)
        {
            var d = _departmentService.UpdateDepartment(Department);
            if (d != null)
            {
                return d;
            }
            else
            {
                return UnprocessableEntity("Department does not exist");
            }
        }

       [HttpDelete("delete/{id}")]
        public bool DeleteDepartment(int id)
        {
            return _departmentService.DeleteDepartment(id);
        }
    }
}
