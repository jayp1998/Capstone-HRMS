using System.Collections.Generic;
using System.Linq;
using Capstone_HRMS.Data.Models;
using HRMS_Project.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Capstone_HRMS.Data.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly ApplicationDbContext _context;
         public AttendanceService(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddAttendance(Attendance d)
        {
             if (!AttendanceExists(d))
            {
                 _context.Attendance.Add(d);
                _context.SaveChanges();

                return d.AttendanceId;
            }
            else
            {
                return 0;
            }
        }

        public bool DeleteAttendance(int id)
        {
            var result = GetAttendanceById(id);
            if (result != null)
            {
                _context.Entry(result).State = EntityState.Deleted;
                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Attendance> GetAllAttendance()
        {
            return _context.Attendance.ToList();
        }

        public Attendance GetAttendanceById(int Id)
        {
            Attendance result = _context.Attendance.Where(e => e.AttendanceId == Id).FirstOrDefault();
            return result;
        }
        public List<Attendance> GetAttendanceByEmpId(int id)
        {
            return  _context.Attendance.Where(e => e.EmployeeId == id).ToList();
           
        }

        public bool AttendanceExists(Attendance attendance)
        {
            return _context.Attendance.Any(e => e.Date == attendance.Date && e.EmployeeId == attendance.EmployeeId);
        }

        public Attendance UpdateAttendance(Attendance d)
        {
             var result = GetAttendanceById(d.AttendanceId);
            if (result != null && !AttendanceExists(d))
            {
                result.Date = d.Date;
                result.EmployeeId = d.EmployeeId;
                result.PunchIn = d.PunchIn;
                result.PunchOut = d.PunchOut;
                result.PresentAbsent = d.PresentAbsent;
                
                _context.Entry(result).State = EntityState.Modified;
                _context.SaveChanges();

                return result;
            }
            else
            {
                return null;
            }
        }

    }
}