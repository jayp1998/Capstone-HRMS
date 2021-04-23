using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone_HRMS.Data.Models;
using Capstone_HRMS.Data.Services;
using HRMS_Project.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Capstone_HRMS.Controllers
{
    [ApiController] 
    [Route("api/[controller]")]
    public class AttendanceController : ControllerBase
    {
       private readonly ApplicationDbContext _context;
         private readonly IAttendanceService _AttendanceService;

        public AttendanceController(ApplicationDbContext context, IAttendanceService AttendanceService)
        {
            _context = context;
            _AttendanceService = AttendanceService;
        }

        //api/Attendance/GetAllAttendance
        [HttpGet("[action]")]
       public IActionResult GetAllAttendance()
        {
             var result  = from attendance in _context.Set<Attendance>()
              from emp in _context.Set<Employee>().Where(emp => emp.EmployeeId == attendance.EmployeeId).DefaultIfEmpty()
             select new {attendance.AttendanceId,
                        attendance.Date,
                        attendance.PunchIn,
                        attendance.PunchOut,
                        attendance.PresentAbsent,
                        emp.EmployeeId,
                        emp.FirstName,
                        emp.LastName};
            return Ok(result);
        }

        //api/Attendance/1
        [HttpGet("[action]/{EmployeeId}")]
        public IActionResult GetAttendanceByEmpId(int EmployeeId)
        {
             var result  = from attendance in _context.Set<Attendance>().Where(emp => emp.EmployeeId == EmployeeId)
              from emp in _context.Set<Employee>().Where(emp => emp.EmployeeId == attendance.EmployeeId).DefaultIfEmpty()
             select new {attendance.AttendanceId,
                        attendance.Date,
                        attendance.PunchIn,
                        attendance.PunchOut,
                        attendance.PresentAbsent,
                        emp.EmployeeId,
                        emp.FirstName,
                        emp.LastName};
            return Ok(result);
        }

        //api/Attendance/add
        [HttpPost("add")]
        public ActionResult<Attendance> AddAttendance(Attendance Attendance)
        {
            int temp = _AttendanceService.AddAttendance(Attendance);
            if (temp > 0)
            {
                return CreatedAtAction(nameof(Attendance), new { id = temp }, Attendance);
            }
            else
            {
                return UnprocessableEntity("Attendance already exist");
            }
        }

        //api/Attendance/update
        [HttpPut("update")]
        public ActionResult<Attendance> UpdateAttendance(Attendance Attendance)
        {
            var d = _AttendanceService.UpdateAttendance(Attendance);
            if (d != null)
            {
                return d;
            }
            else
            {
                return UnprocessableEntity("Attendance does not exist");
            }
        }

        //api/Attendance/delete/5
        [HttpDelete("delete/{id}")]
        public bool DeleteAttendance(int id)
        {
            return _AttendanceService.DeleteAttendance(id);
        }
    }
}