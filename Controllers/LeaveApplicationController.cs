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
    public class LeaveApplicationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
         private readonly ILeaveApplicationService _leaveApplicationService;

        public LeaveApplicationController(ApplicationDbContext context, ILeaveApplicationService leaveApplicationService)
        {
            _context = context;
            _leaveApplicationService = leaveApplicationService;
        }
        
        //api/LeaveApplication/GetAllLeaveApplication
        [HttpGet("[action]")]
       public IActionResult GetAllLeaveApplication()
        {
            
        var result  = from  leaveApp in _context.Set<LeaveApplication>()
             from emp in _context.Set<Employee>().Where(emp => emp.EmployeeId == leaveApp.EmployeeId).DefaultIfEmpty()
             from emp2 in _context.Set<Employee>().Where(emp2 => emp2.EmployeeId == leaveApp.LeaveAppliedTo).DefaultIfEmpty()
             from leaveType in _context.Set<LeaveType>().Where(leaveType => leaveType.LeaveTypeId == leaveApp.LeaveTypeId).DefaultIfEmpty()
             from leaveStatus in _context.Set<LeaveStatus>().Where(leaveStatus => leaveStatus.LeaveStatusId == leaveApp.LeaveStatusId).DefaultIfEmpty()
             select new {
                  leaveApp.LeaveApplicationId,
                        LeaveAppliedBy = emp.FirstName + " " + emp.LastName,
                        emp.EmployeeId,
                        leaveApp.LeaveApplicationDate, 
                        LeaveAppliedTo = emp2.FirstName +" "+ emp2.LastName ,
                        leaveApp.LeaveStatusUpdatedAt, 
                        leaveApp.LeaveStatusUpdatedBy, 
                        leaveApp.FromDate, 
                        leaveApp.ToDate ,
                        leaveType.TypeName ,
                        leaveStatus.Status ,
                        leaveApp.Reason };
            return Ok(result);
        }
        
        //api/LeaveApplication/GetAllLeaveApplicationByEmployeeId/1
        [HttpGet("[action]/{id}")]
       public IActionResult GetLeaveApplicationByLeaveAppliedBy(long id)
        {
            
            var result  = from  leaveApp in _context.Set<LeaveApplication>()
             from emp in _context.Set<Employee>().Where(emp => emp.EmployeeId == leaveApp.EmployeeId).DefaultIfEmpty()
             from emp2 in _context.Set<Employee>().Where(emp2 => emp2.EmployeeId == leaveApp.LeaveAppliedTo).DefaultIfEmpty()
             from leaveType in _context.Set<LeaveType>().Where(leaveType => leaveType.LeaveTypeId == leaveApp.LeaveTypeId).DefaultIfEmpty()
             from leaveStatus in _context.Set<LeaveStatus>().Where(leaveStatus => leaveStatus.LeaveStatusId == leaveApp.LeaveStatusId).DefaultIfEmpty()
             select new {
                  leaveApp.LeaveApplicationId,
                        LeaveAppliedBy = emp.FirstName + " " + emp.LastName,
                        emp.EmployeeId,
                        leaveApp.LeaveApplicationDate, 
                        LeaveAppliedTo = emp2.FirstName +" "+ emp2.LastName ,
                        leaveApp.LeaveStatusUpdatedAt, 
                        leaveApp.LeaveStatusUpdatedBy, 
                        leaveApp.FromDate, 
                        leaveApp.ToDate ,
                        leaveType.TypeName ,
                        leaveStatus.Status ,
                        leaveApp.Reason };
            return Ok(result.Where(leaveApp => leaveApp.EmployeeId == id));
        }
        
         //api/LeaveApplication/GetLeaveApplicationByLeaveAppliedTo/1
        [HttpGet("[action]/{id}")]
       public IActionResult GetLeaveApplicationByLeaveAppliedTo (long id)
        {
            
             var result  = from  leaveApp in _context.Set<LeaveApplication>()
             from emp in _context.Set<Employee>().Where(emp => emp.EmployeeId == leaveApp.EmployeeId).DefaultIfEmpty()
             from emp2 in _context.Set<Employee>().Where(emp2 => emp2.EmployeeId == leaveApp.LeaveAppliedTo).DefaultIfEmpty()
             from leaveType in _context.Set<LeaveType>().Where(leaveType => leaveType.LeaveTypeId == leaveApp.LeaveTypeId).DefaultIfEmpty()
             from leaveStatus in _context.Set<LeaveStatus>().Where(leaveStatus => leaveStatus.LeaveStatusId == leaveApp.LeaveStatusId).DefaultIfEmpty()
             select new {
                  leaveApp.LeaveApplicationId,
                        LeaveAppliedBy = emp.FirstName + " " + emp.LastName,
                        emp.EmployeeId,
                        leaveApp.LeaveApplicationDate, 
                        LeaveAppliedToName = emp2.FirstName +" "+ emp2.LastName ,
                        leaveApp.LeaveAppliedTo,
                        leaveApp.LeaveStatusUpdatedAt, 
                        leaveApp.LeaveStatusUpdatedBy, 
                        leaveApp.FromDate, 
                        leaveApp.ToDate ,
                        leaveType.TypeName ,
                        leaveStatus.Status ,
                        leaveApp.Reason };
            return Ok(result.Where(leaveApp => leaveApp.LeaveAppliedTo == id));
        }

        //api/LeaveApplication/add
        [HttpPost("add")]
        public ActionResult<LeaveApplication> AddLeaveApplication(LeaveApplication leaveApp)
        {
            int temp = _leaveApplicationService.AddLeaveApplication(leaveApp);
            if (temp > 0)
            {
                return CreatedAtAction(nameof(leaveApp), new { id = temp }, leaveApp);
            }
            else
            {
                return UnprocessableEntity("LeaveApplication already exist");
            }
        }

        ///api/LeaveApplication/update
        [HttpPut("update")]
        public ActionResult<LeaveApplication> UpdateLeaveApplication(LeaveApplication leaveApp)
        {
            var e = _leaveApplicationService.UpdateLeaveApplication(leaveApp);
            if (e != null)
            {
                return e;
            }
            else
            {
                return UnprocessableEntity("LeaveApplication does not exist");
            }
        }

        ///api/LeaveApplication/delete/1
        [HttpDelete("delete/{id}")]
        public bool DeleteEmployee(int id)
        {
            return _leaveApplicationService.DeleteLeaveApplication(id);
        }

    }
}