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
    public class JobProfileDetailController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
         private readonly IJobProfileDetailService _JobProfileDetailService;

        public JobProfileDetailController(ApplicationDbContext context, IJobProfileDetailService JobProfileDetailService)
        {
            _context = context;
            _JobProfileDetailService = JobProfileDetailService;
        }

         //api/JobProfileDetail/GetAllJobProfileDetail
        [HttpGet("[action]")]
       public IActionResult GetAllJobProfileDetail()
        {
            
        var result  = from  jobProfile in _context.Set<JobProfileDetail>()
             from emp in _context.Set<Employee>().Where(emp => emp.EmployeeId == jobProfile.EmployeeId).DefaultIfEmpty()
             from emp2 in _context.Set<Employee>().Where(emp2 => emp2.EmployeeId == jobProfile.ReportsTo).DefaultIfEmpty()
             select new {
                        jobProfile.JobProfileDetailId,
                        EmpFullName = emp.FirstName + " " + emp.LastName,
                        emp.EmployeeId,
                        jobProfile.HireDate, 
                        ReportsToName = emp2.FirstName +" "+ emp2.LastName ,
                        jobProfile.ReportsTo, 
                        jobProfile.ProbationaryPeriodEndDate, 
                        jobProfile.ProbationaryPeriodStartDate ,
                        };
            return Ok(result);
        }

        //api/JobProfileDetail/GetAllJobProfileDetailByEmpId/1
        [HttpGet("[action]/{id}")]
       public IActionResult GetAllJobProfileDetailByEmpId(int id)
        {
            
        var result  = from  jobProfile in _context.Set<JobProfileDetail>()
             from emp in _context.Set<Employee>().Where(emp => emp.EmployeeId == jobProfile.EmployeeId).DefaultIfEmpty()
             from emp2 in _context.Set<Employee>().Where(emp2 => emp2.EmployeeId == jobProfile.ReportsTo).DefaultIfEmpty()
             select new {
                        jobProfile.JobProfileDetailId,
                        EmpFullName = emp.FirstName + " " + emp.LastName,
                        emp.EmployeeId,
                        jobProfile.HireDate, 
                        ReportsToEmpName = emp2.FirstName +" "+ emp2.LastName ,
                        jobProfile.ReportsTo, 
                        jobProfile.ProbationaryPeriodEndDate, 
                        jobProfile.ProbationaryPeriodStartDate ,
                        };
            return Ok(result.Where(job => job.EmployeeId == id));
        }

        //api/JobProfileDetail/add
        [HttpPost("add")]
        public ActionResult<JobProfileDetail> AddJobProfileDetail(JobProfileDetail leaveApp)
        {
            long temp = _JobProfileDetailService.AddJobProfileDetail(leaveApp);
            if (temp > 0)
            {
                return CreatedAtAction(nameof(leaveApp), new { id = temp }, leaveApp);
            }
            else
            {
                return UnprocessableEntity("JobProfileDetail already exist");
            }
        }

        ///api/JobProfileDetail/update
        [HttpPut("update")]
        public ActionResult<JobProfileDetail> UpdateJobProfileDetail(JobProfileDetail leaveApp)
        {
            var e = _JobProfileDetailService.UpdateJobProfileDetail(leaveApp);
            if (e != null)
            {
                return e;
            }
            else
            {
                return UnprocessableEntity("JobProfileDetail does not exist Or same Employee already exist!");
            }
        }

        ///api/JobProfileDetail/delete/1
        [HttpDelete("delete/{id}")]
        public bool DeleteEmployee(int id)
        {
            return _JobProfileDetailService.DeleteJobProfileDetail(id);
        }
            
    }
}