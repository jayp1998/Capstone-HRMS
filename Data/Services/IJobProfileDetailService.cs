using System.Collections.Generic;
using HRMS_Project.Data.Models;

namespace Capstone_HRMS.Data.Services
{
    public interface IJobProfileDetailService
    {
        long AddJobProfileDetail(JobProfileDetail d);

        JobProfileDetail UpdateJobProfileDetail(JobProfileDetail d);

        bool DeleteJobProfileDetail(long id);

        List<JobProfileDetail> GetAllJobProfileDetail();

        JobProfileDetail GetJobProfileDetailById(long id);

        List<JobProfileDetail> GetJobProfileDetailByEmpID(long id);

        bool JobProfileDetailExists(long id);
        
    }
}