using System.Collections.Generic;
using System.Linq;
using HRMS_Project.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Capstone_HRMS.Data.Services
{
    public class LeaveTypeService : ILeaveTypeService
    {
         private readonly ApplicationDbContext _context;
         public LeaveTypeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddLeaveType(LeaveType d)
        {
             if (!LeaveTypeExists(d.TypeName))
            {
                 _context.LeaveType.Add(d);
                _context.SaveChanges();

                return d.LeaveTypeId;
            }
            else
            {
                return 0;
            }
        }

        public bool DeleteLeaveType(int id)
        {
            var result = GetLeaveTypeById(id);
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

        public List<LeaveType> GetAllLeaveType()
        {
            return _context.LeaveType.ToList();
        }

        public LeaveType GetLeaveTypeById(int Id)
        {
            LeaveType result = _context.LeaveType.Where(e => e.LeaveTypeId == Id).FirstOrDefault();
            return result;
        }

        public LeaveType GetLeaveTypeByName(string name)
        {
            LeaveType result = _context.LeaveType.Where(e => e.TypeName.Contains(name)).FirstOrDefault();

            return result;
        }

        public bool LeaveTypeExists(string LeaveTypeName)
        {
            return _context.LeaveType.Any(e => e.TypeName == LeaveTypeName);
        }

        public LeaveType UpdateLeaveType(LeaveType d)
        {
             var result = GetLeaveTypeById(d.LeaveTypeId);
            if (result != null)
            {
                if (result.TypeName != d.TypeName && LeaveTypeExists(d.TypeName))
                {
                    return null;
                }
                result.TypeName = d.TypeName;
                result.NumberOfHours = d.NumberOfHours;
                
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