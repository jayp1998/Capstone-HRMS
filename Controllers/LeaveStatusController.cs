using HRMS_Project.Data.Models;
using HRMS_Project.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
namespace HRMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveStatusController : ControllerBase
    {
        
        private readonly ApplicationDbContext _context;
        private readonly ILeaveStatusService _LeaveStatusService;

        public LeaveStatusController(ApplicationDbContext context, ILeaveStatusService LeaveStatusService)
        {
            _context = context;
            _LeaveStatusService = LeaveStatusService;
        }

        //api/LeaveStatus/GetAllLeaveStatus
        [HttpGet("[action]")]
        public ActionResult<IEnumerable<LeaveStatus>> GetAllLeaveStatus()
        {
            return _LeaveStatusService.GetAllLeaveStatus();
        }

        //api/LeaveStatus/GetLeaveStatusById/1
        [HttpGet("[action]/{id}")]
        public ActionResult<LeaveStatus> GetLeaveStatusById(int id)
        {
            return _LeaveStatusService.GetLeaveStatusById(id);
        }

        //api/LeaveStatus/GetLeaveStatusByname/PL
        [HttpGet("[action]/{status}")]
        public ActionResult<LeaveStatus> GetLeaveStatusByname(string status)
        {
            return _LeaveStatusService.GetLeaveStatusByName(status);
        }

        ///api/LeaveStatus/add
        [HttpPost("add")]
        public ActionResult<LeaveStatus> AddLeaveStatus(LeaveStatus leaveStatus)
        {
            int temp = _LeaveStatusService.AddLeaveStatus(leaveStatus);
            if (temp > 0)
            {
                return CreatedAtAction(nameof(LeaveStatus), new { id = temp }, leaveStatus);
            }
            else
            {
                return UnprocessableEntity("Leave Status already exist");
            }
        }

        //api/LeaveStatus/update
        [HttpPut("update")]
        public ActionResult<LeaveStatus> UpdateLeaveStatus(LeaveStatus leaveStatus)
        {
            var d = _LeaveStatusService.UpdateLeaveStatus(leaveStatus);
            if (d != null)
            {
                return d;
            }
            else
            {
                return UnprocessableEntity("Leave Status does not exist");
            }
        }

        //api/LeaveStatus/delete/5
        [HttpDelete("delete/{id}")]
        public bool DeleteLeaveStatus(int id)
        {
            return _LeaveStatusService.DeleteLeaveStatus(id);
        }
    }
}