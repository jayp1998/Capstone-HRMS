using System.Collections.Generic;
using HRMS_Project.Data.Models;

namespace Capstone_HRMS.Data.Services
{
    public interface ILeaveTypeService
    {
        int AddLeaveType(LeaveType d);

        LeaveType UpdateLeaveType(LeaveType d);

        bool DeleteLeaveType(int id);

        List<LeaveType> GetAllLeaveType();

        LeaveType GetLeaveTypeById(int Id);

        LeaveType GetLeaveTypeByName(string name);

        bool LeaveTypeExists(string name);
    }
}