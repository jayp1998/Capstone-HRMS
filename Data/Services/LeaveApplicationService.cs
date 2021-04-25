using System.Collections.Generic;
using System.Linq;
using HRMS_Project.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Capstone_HRMS.Data.Services
{
    public class LeaveApplicationService : ILeaveApplicationService
    {
          private readonly ApplicationDbContext _context;

        public LeaveApplicationService(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddLeaveApplication(LeaveApplication d)
        {
            if (!LeaveApplicationExists(d))
            {
                _context.LeaveApplication.Add(d);
                _context.SaveChanges();

                return d.LeaveApplicationId;
            }
            else
            {
                return 0;
            }
        }

        public bool DeleteLeaveApplication(int id)
        {
            var result = GetLeaveApplicationById(id);
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

         public bool LeaveApplicationExists(LeaveApplication e) 
        {
             return _context.LeaveApplication.Any(l => l.EmployeeId == e.EmployeeId && l.FromDate == e.FromDate  );
        }

        public List<LeaveApplication> GetAllLeaveApplications()
        {
            return _context.LeaveApplication.ToList();
        }

        public LeaveApplication GetLeaveApplicationById(int id)
        {
            return  _context.LeaveApplication.Where(e => e.LeaveApplicationId == id).FirstOrDefault();
        }

        public List<LeaveApplication> GetLeaveApplicationByLeaveAppliedBy(long id)
        {
           return  _context.LeaveApplication.Where(e => e.EmployeeId == id).ToList();
        }

        public LeaveApplication UpdateLeaveApplication(LeaveApplication app)
        {
           var result = GetLeaveApplicationById(app.LeaveApplicationId);
            if (result != null)
            {
                 if (result.EmployeeId != app.EmployeeId && LeaveApplicationExists(app) )
                {
                    return null;
                }

                 result.EmployeeId = app.EmployeeId;
                 result.LeaveApplicationDate = app.LeaveApplicationDate;
                 result.LeaveTypeId = app.LeaveTypeId;
                 result.FromDate = app.FromDate;
                 result.ToDate = app.ToDate;
                 result.Reason = app.Reason;
                 result.Hours = app.Hours;
                 result.LeaveAppliedTo = app.LeaveAppliedTo;
                 result.LeaveStatusId = app.LeaveStatusId;
                 result.Comment = app.Comment;
                 result.LeaveStatusUpdatedBy = app.LeaveStatusUpdatedBy;
                 result.LeaveStatusUpdatedAt = app.LeaveStatusUpdatedAt;

                _context.Entry(result).State = EntityState.Modified;
                _context.SaveChanges();

                return result;
            }
            else
            {
                return null;
            }
        }

        public List<LeaveApplication> GetLeaveApplicationByLeaveAppliedTo(long id)
        {
            return  _context.LeaveApplication.Where(e => e.LeaveAppliedTo == id).ToList();
        }
    }
}