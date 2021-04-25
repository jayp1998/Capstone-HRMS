using HRMS_Project.Data.Models;
using System;
using System.Collections.Generic;

namespace Capstone_HRMS.Data.Services
{
    public interface ILeaveApplicationService
    {
        long AddLeaveApplication(LeaveApplication d);

        LeaveApplication UpdateLeaveApplication(LeaveApplication d);

        bool DeleteLeaveApplication(long id);

        List<LeaveApplication> GetAllLeaveApplications();

        LeaveApplication GetLeaveApplicationById(long id);

        bool LeaveApplicationExists(LeaveApplication d);
        List<LeaveApplication> GetLeaveApplicationByLeaveAppliedBy(long id);
        List<LeaveApplication> GetLeaveApplicationByLeaveAppliedTo(long id);
    }
}