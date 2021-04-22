using System.Collections.Generic;
using System.Linq;
using HRMS_Project.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMS_Project.Data.Services
{
    public class LeaveStatusService : ILeaveStatusService
    {
         private readonly ApplicationDbContext _context;
         public LeaveStatusService(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddLeaveStatus(LeaveStatus d)
        {
             if (!LeaveStatusExists(d.Status))
            {
                 _context.LeaveStatus.Add(d);
                _context.SaveChanges();

                return d.LeaveStatusId;
            }
            else
            {
                return 0;
            }
        }

        public bool DeleteLeaveStatus(int id)
        {
            var result = GetLeaveStatusById(id);
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

        public List<LeaveStatus> GetAllLeaveStatus()
        {
            return _context.LeaveStatus.ToList();
        }

        public LeaveStatus GetLeaveStatusById(int Id)
        {
            LeaveStatus result = _context.LeaveStatus.Where(e => e.LeaveStatusId == Id).FirstOrDefault();
            return result;
        }

        public LeaveStatus GetLeaveStatusByName(string name)
        {
            LeaveStatus result = _context.LeaveStatus.Where(e => e.Status.Contains(name)).FirstOrDefault();

            return result;
        }

        public bool LeaveStatusExists(string LeaveStatusName)
        {
            return _context.LeaveStatus.Any(e => e.Status == LeaveStatusName);
        }

        public LeaveStatus UpdateLeaveStatus(LeaveStatus d)
        {
             var result = GetLeaveStatusById(d.LeaveStatusId);
            if (result != null)
            {
                result.Status = d.Status;

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