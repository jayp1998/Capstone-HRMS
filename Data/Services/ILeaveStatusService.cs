using System.Collections.Generic;
using HRMS_Project.Data.Models;

namespace HRMS_Project.Data.Services
{
    public interface ILeaveStatusService
    {
         int AddLeaveStatus(LeaveStatus d);

        LeaveStatus UpdateLeaveStatus(LeaveStatus d);

        bool DeleteLeaveStatus(int id);

        List<LeaveStatus> GetAllLeaveStatus();

        LeaveStatus GetLeaveStatusById(int Id);

        LeaveStatus GetLeaveStatusByName(string name);

        bool LeaveStatusExists(string LeaveStatusName);
        
    }
}