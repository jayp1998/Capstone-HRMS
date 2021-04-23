using Capstone_HRMS.Data.Services;
using HRMS_Project.Data.Models;
using HRMS_Project.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace HRMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypeController : ControllerBase
    {
        
        private readonly ApplicationDbContext _context;
        private readonly ILeaveTypeService _LeaveTypeService;

        public LeaveTypeController(ApplicationDbContext context, ILeaveTypeService LeaveTypeService)
        {
            _context = context;
            _LeaveTypeService = LeaveTypeService;
        }

        //api/LeaveType/GetAllLeaveType
        [HttpGet("[action]")]
        public ActionResult<IEnumerable<LeaveType>> GetAllLeaveType()
        {
            return _LeaveTypeService.GetAllLeaveType();
        }

        //api/LeaveType/GetLeaveTypeById/1
        [HttpGet("[action]/{id}")]
        public ActionResult<LeaveType> GetLeaveTypeById(int id)
        {
            return _LeaveTypeService.GetLeaveTypeById(id);
        }

        //api/LeaveType/GetLeaveTypeByname/PL
        [HttpGet("[action]/{status}")]
        public ActionResult<LeaveType> GetLeaveTypeByname(string status)
        {
            return _LeaveTypeService.GetLeaveTypeByName(status);
        }

        ///api/LeaveType/add
        [HttpPost("add")]
        public ActionResult<LeaveType> AddLeaveType(LeaveType LeaveType)
        {
            int temp = _LeaveTypeService.AddLeaveType(LeaveType);
            if (temp > 0)
            {
                return CreatedAtAction(nameof(LeaveType), new { id = temp }, LeaveType);
            }
            else
            {
                return UnprocessableEntity("Leave type already exist");
            }
        }

        //api/LeaveType/update
        [HttpPut("update")]
        public ActionResult<LeaveType> UpdateLeaveType(LeaveType LeaveType)
        {
            var d = _LeaveTypeService.UpdateLeaveType(LeaveType);
            if (d != null)
            {
                return d;
            }
            else
            {
                return UnprocessableEntity("Leave type does not exist");
            }
        }

        //api/LeaveType/delete/5
        [HttpDelete("delete/{id}")]
        public bool DeleteLeaveType(int id)
        {
            return _LeaveTypeService.DeleteLeaveType(id);
        }
    }
}