using HRMS_Project.Data.Models;
using System;
using System.Collections.Generic;

namespace Capstone_HRMS.Data.Services
{
    public interface ILeaveApplicationService
    {
        int AddLeaveApplication(LeaveApplication d);

        LeaveApplication UpdateLeaveApplication(LeaveApplication d);

        bool DeleteLeaveApplication(int id);

        List<LeaveApplication> GetAllLeaveApplications();

        LeaveApplication GetLeaveApplicationById(int id);

        bool LeaveApplicationExists(LeaveApplication d);
        List<LeaveApplication> GetLeaveApplicationByLeaveAppliedBy(int id);
        List<LeaveApplication> GetLeaveApplicationByLeaveAppliedTo(int id);
    }
}