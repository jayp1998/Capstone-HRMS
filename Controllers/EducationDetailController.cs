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
    public class EducationDetailController: ControllerBase
    {
        private readonly ApplicationDbContext _context;
         private readonly IEducationDetailService _EducationDetailService;

        public EducationDetailController(ApplicationDbContext context, IEducationDetailService EducationDetailService)
        {
            _context = context;
            _EducationDetailService = EducationDetailService;
        }

         //api/EducationDetail/GetAllEducationDetail
        [HttpGet("[action]")]
       public IActionResult GetAllEducationDetail()
       {
            
        var result  = from  eduDetail in _context.Set<EducationDetail>()
             from emp in _context.Set<Employee>().Where(emp => emp.EmployeeId == eduDetail.EmployeeId).DefaultIfEmpty()
             select new {
                        eduDetail.EducationDetailId,
                        EmpFullName = emp.FirstName + " " + emp.LastName,
                        emp.EmployeeId,
                        eduDetail.DegreeName , 
                        eduDetail.StartDate , 
                        eduDetail.EndDate, 
                        eduDetail.Gpa ,
                        eduDetail.Specialization ,
                        eduDetail.UniversityName ,
                        };
            return Ok(result);
        }

        //api/EducationDetail/GetAllEducationDetailByEmpId/1
        [HttpGet("[action]/{id}")]
       public IActionResult GetAllEducationDetailByEmpId(int id)
        {
          var result  = from  eduDetail in _context.Set<EducationDetail>()
             from emp in _context.Set<Employee>().Where(emp => emp.EmployeeId == eduDetail.EmployeeId).DefaultIfEmpty()
             select new {
                        eduDetail.EducationDetailId,
                        EmpFullName = emp.FirstName + " " + emp.LastName,
                        emp.EmployeeId,
                        eduDetail.DegreeName , 
                        eduDetail.StartDate , 
                        eduDetail.EndDate, 
                        eduDetail.Gpa ,
                        eduDetail.Specialization ,
                        eduDetail.UniversityName ,
                        };
            return Ok(result.Where(edu => edu.EmployeeId == id));
        }

        //api/EducationDetail/add
        [HttpPost("add")]
        public ActionResult<EducationDetail> AddEducationDetail(EducationDetail leaveApp)
        {
            int temp = _EducationDetailService.AddEducationDetail(leaveApp);
            if (temp > 0)
            {
                return CreatedAtAction(nameof(leaveApp), new { id = temp }, leaveApp);
            }
            else
            {
                return UnprocessableEntity("EducationDetail already exist");
            }
        }

        //api/EducationDetail/update
        [HttpPut("update")]
        public ActionResult<EducationDetail> UpdateEducationDetail(EducationDetail leaveApp)
        {
            var e = _EducationDetailService.UpdateEducationDetail(leaveApp);
            if (e != null)
            {
                return e;
            }
            else
            {
                return UnprocessableEntity("EducationDetail does not exist Or same Employee Id already exist!");
            }
        }

        //api/EducationDetail/delete/1
        [HttpDelete("delete/{id}")]
        public bool DeleteEmployee(int id)
        {
            return _EducationDetailService.DeleteEducationDetail(id);
        }            
    }
}