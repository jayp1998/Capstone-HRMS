using System.Collections.Generic;
using HRMS_Project.Data.Models;

namespace Capstone_HRMS.Data.Services
{
    public interface IJobProfileDetailService
    {
        int AddJobProfileDetail(JobProfileDetail d);

        JobProfileDetail UpdateJobProfileDetail(JobProfileDetail d);

        bool DeleteJobProfileDetail(int id);

        List<JobProfileDetail> GetAllJobProfileDetail();

        JobProfileDetail GetJobProfileDetailById(int id);

        List<JobProfileDetail> GetJobProfileDetailByEmpID(int id);

        bool JobProfileDetailExists(int id);
        
    }
}